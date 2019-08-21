namespace HclFusion
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.label4 = new System.Windows.Forms.Label();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.OpenVisibleFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.OpenThermalFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.SaveCompositeFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button4);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.trackBar2);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.trackBar1);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.textBox2);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(259, 573);
      this.panel1.TabIndex = 0;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(90, 333);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 8;
      this.button4.Text = "Save";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(90, 291);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "Fuse";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // trackBar2
      // 
      this.trackBar2.Location = new System.Drawing.Point(12, 230);
      this.trackBar2.Maximum = 100;
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(236, 45);
      this.trackBar2.TabIndex = 6;
      this.trackBar2.TickFrequency = 10;
      this.trackBar2.Value = 50;
      this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 214);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Chroma 50%";
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(12, 170);
      this.trackBar1.Maximum = 300;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(236, 45);
      this.trackBar1.TabIndex = 5;
      this.trackBar1.TickFrequency = 20;
      this.trackBar1.Value = 100;
      this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 154);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Hue Gain 1.00";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(12, 85);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(205, 20);
      this.textBox2.TabIndex = 3;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(223, 84);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(25, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "...";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(153, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Thermal Image, gray scale only";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 28);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(205, 20);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(223, 27);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(25, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(161, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Visible Image, gray scale or color";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(259, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(764, 573);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // OpenVisibleFileDialog
      // 
      this.OpenVisibleFileDialog.DefaultExt = "bmp";
      this.OpenVisibleFileDialog.FileName = "openFileDialog1";
      this.OpenVisibleFileDialog.Title = "Select Visible Image";
      // 
      // OpenThermalFileDialog
      // 
      this.OpenThermalFileDialog.DefaultExt = "bmp";
      this.OpenThermalFileDialog.FileName = "openFileDialog2";
      this.OpenThermalFileDialog.Title = "Select Thermal Image";
      // 
      // SaveCompositeFileDialog
      // 
      this.SaveCompositeFileDialog.DefaultExt = "bmp";
      this.SaveCompositeFileDialog.Title = "Save Composite File";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1023, 573);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "HCL Fusion";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.OpenFileDialog OpenVisibleFileDialog;
    public System.Windows.Forms.OpenFileDialog OpenThermalFileDialog;
    public System.Windows.Forms.TrackBar trackBar2;
    public System.Windows.Forms.TrackBar trackBar1;
    public System.Windows.Forms.TextBox textBox2;
    public System.Windows.Forms.TextBox textBox1;
    public System.Windows.Forms.Label label4;
    public System.Windows.Forms.Label label3;
    private System.Windows.Forms.SaveFileDialog SaveCompositeFileDialog;
  }
}

