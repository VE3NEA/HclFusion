# HCL Fusion

The program fuses a visible light picture and a thermal camera image
into a single image that retains both high resolution detail of
the visible image and color-coded temperature information from the thermal image.

### Algorithm

Fusion is performed in the 
[HCL color space](https://en.wikipedia.org/wiki/HCL_color_space)
(Hue, Chroma, Luminance). 
The visual image, converted to gray scale, is used as Luminance, and
Hue is computed from the thermal data.

### Example
![Screenshot](Bmp/visible.bmp)
Visible image

![Screenshot](Bmp/thermal.bmp)
Thermal image

![Screenshot](Bmp/composite.bmp)
Composite image.
