using Colourful;
using Colourful.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace HclFusion
{
  public partial class Form1 : Form
  {
    private double[] visibles, thermals;
    private Bitmap bitmap;
    double hueGain = 1;
    double chroma = 50;

    //----------------------------------------------------------------------------------------------
    //                                       system
    //----------------------------------------------------------------------------------------------
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (OpenVisibleFileDialog.ShowDialog() == DialogResult.OK)
        textBox1.Text = Path.GetFileName(OpenVisibleFileDialog.FileName);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (OpenThermalFileDialog.ShowDialog() == DialogResult.OK)
        textBox2.Text = Path.GetFileName(OpenThermalFileDialog.FileName);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      FuseImages();
      pictureBox1.Image = bitmap;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (SaveCompositeFileDialog.ShowDialog() == DialogResult.OK)
        bitmap.Save(SaveCompositeFileDialog.FileName, ImageFormat.Bmp);
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
      hueGain = trackBar1.Value / 100d; //0..300 -> 0.0..3.0
      chroma = trackBar2.Value;         //0..100

      label3.Text = $"Hue Gain {hueGain:F2}";
      label4.Text = $"Chroma {(chroma):F0}%";
    }




    //----------------------------------------------------------------------------------------------
    //                                     HCL Fusion
    //----------------------------------------------------------------------------------------------
    private void FuseImages()
    {
      LoadImage(OpenThermalFileDialog.FileName, false);
      thermals = GetImageLuminance();

      LoadImage(OpenVisibleFileDialog.FileName, true);
      visibles = GetImageLuminance();

      FuseLuminances();
    }

    //this is the core of the algorithm. the output image is computed in the HCL color space 
    //using the gray scale visible image for Luminance and thermal image for Hue
    private unsafe void FuseLuminances()
    {
      var converter = new ColourfulConverter { WhitePoint = Illuminants.D65 };

      var data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
        ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
      int* dst = (int*)data.Scan0;

      for (int i = 0; i < visibles.Length; i++)
      {
        double luminance = visibles[i] * 100; //0..100
        double hue =Math.Min(1, thermals[i] * hueGain);
        hue = 300 - (int)(hue * 300); //0..300

        //compose HCL color
        var hclColor = new LChabColor(luminance, chroma, hue);

        //convert to RGB and put in bitmap
        Color color = converter.ToRGB(hclColor);
        *dst++ = (color.R << 16) | (color.G << 8) | color.B;
      }
      bitmap.UnlockBits(data);
    }




    //----------------------------------------------------------------------------------------------
    //                                  image loading
    //----------------------------------------------------------------------------------------------

    //load image and extract luminance
    private unsafe double[] GetImageLuminance()
    {
      //prepare to convert between RGB and HCL
      var converter = new ColourfulConverter { WhitePoint = Illuminants.D65 };
      double[] result = new double[bitmap.Width * bitmap.Height];

      //prepare to read bitmap
      var data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
        ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
      int* src = (int*)data.Scan0;

      for (int pix = 0; pix < result.Length; pix++)
      {
        //read RGB color
        var intValue = *src++;
        var color = Color.FromArgb((byte)(intValue >> 16), (byte)(intValue >> 8), (byte)intValue);

        //convert to HCL
        var hclColor = converter.ToLChab((RGBColor)color);

        //take luminance (0..100)
        result[pix] = hclColor.L;
      }
      bitmap.UnlockBits(data);

      //normalize values
      var min = result.Min();
      var max = result.Max();
      var scale = 1.0 / (max - min);
      for (int i = 0; i < result.Length; i++) result[i] = (result[i] - min) * scale;

      return result;
    }

    //load regular image
    private void LoadImage(string path, bool stretch)
    {
      var image = (Path.GetExtension(path).ToLower() == ".tiff") ? LoadThermalTiff(path) : Bitmap.FromFile(path);

      //force 32-bit RGB format and optionally adjust image size
      if (!stretch) bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppRgb);
      using (var g = Graphics.FromImage(bitmap)) { g.DrawImage(image, 0, 0, bitmap.Width, bitmap.Height); }
    }

    //load thermal data from a tiff file created with Seek Thermal App.
    //such files contain three frames, the last frame is thermal data.
    private Bitmap LoadThermalTiff(string path)
    {
      //read tiff frame
      var inStream = new FileStream(path, FileMode.Open);
      var decoder = new TiffBitmapDecoder(inStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
      var frame = BitmapFrame.Create(decoder.Frames[decoder.Frames.Count - 1]);

      //write bitmap
      BitmapEncoder encoder = new BmpBitmapEncoder();
      encoder.Frames.Add(frame);
      var outStream = new MemoryStream();
      encoder.Save(outStream);
      return new Bitmap(outStream);
    }
  }
}