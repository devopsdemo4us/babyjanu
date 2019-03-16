using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Reflection;

// Handling the orientation Exif tag in images using C#
// http://cyotek.com/blog/handling-the-orientation-exif-tag-in-images-using-csharp
// Copyright © 2019 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

namespace Cyotek.Demo.ExifOrientation
{
  internal sealed class DemoBuilder
  {
    #region Methods

    public void Build(string sourceFileName, string outputPath)
    {
      using (Image src = Image.FromFile(sourceFileName))
      {
        for (int i = 1; i <= 8; i++)
        {
          this.BuildDemoImage(i, src, outputPath);
        }
      }
    }

    private void BuildDemoImage(int i, Image src, string outputPath)
    {
      using (Image dst = new Bitmap(src.Width, src.Height, src.PixelFormat))
      {
        string outputFileName;

        this.DrawDemoImage(i, src, dst);
        this.RotateDestination(i, dst);
        this.SetOrientationAttribute(i, dst);

        outputFileName = Path.Combine(outputPath, string.Format("sample-{0}.jpg", i));
        dst.SaveAsJpeg(outputFileName, 100);
      }
    }

    private void DrawDemoImage(int i, Image src, Image dst)
    {
      int titleFontSize;
      int labelFontSize;

      titleFontSize = Math.Max(src.Width, src.Height) / 10;
      labelFontSize = Math.Max(src.Width, src.Height) / 15;

      using (Graphics g = Graphics.FromImage(dst))
      {
        g.Clear(Color.White);
        g.DrawImageUnscaled(src, Point.Empty);

        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        this.DrawText(g, "Top", StringAlignment.Center, StringAlignment.Near, dst.Size, labelFontSize, 1);
        this.DrawText(g, "Bottom", StringAlignment.Center, StringAlignment.Far, dst.Size, labelFontSize, 1);
        this.DrawText(g, "Left", StringAlignment.Near, StringAlignment.Center, dst.Size, labelFontSize, 1);
        this.DrawText(g, "Right", StringAlignment.Far, StringAlignment.Center, dst.Size, labelFontSize, 1);
        this.DrawText(g, i.ToString(), StringAlignment.Center, StringAlignment.Center, dst.Size, titleFontSize, 2);
      }
    }

    private void DrawText(Graphics g, string label, StringAlignment alignment, StringAlignment verticalAlignment, Size canvasSize, int fontSize, float outlineSize)
    {
      using (FontFamily fontFamily = new FontFamily("Segoe UI"))
      {
        using (StringFormat format = new StringFormat
                                     {
                                       Alignment = alignment,
                                       HotkeyPrefix = HotkeyPrefix.None,
                                       LineAlignment = verticalAlignment,
                                       FormatFlags = StringFormatFlags.NoClip
                                     })
        {
          using (GraphicsPath textPath = new GraphicsPath())
          {
            textPath.AddString(label, fontFamily, (int)FontStyle.Bold, fontSize, new Rectangle(Point.Empty, canvasSize), format);

            g.FillPath(Brushes.WhiteSmoke, textPath);

            using (Pen pen = new Pen(Color.LightSlateGray, outlineSize))
            {
              g.DrawPath(pen, textPath);
            }
          }
        }
      }
    }

    private void RotateDestination(int i, Image dst)
    {
      switch (i)
      {
        case 2:
          dst.RotateFlip(RotateFlipType.RotateNoneFlipX);
          break;
        case 3:
          dst.RotateFlip(RotateFlipType.Rotate180FlipNone);
          break;
        case 4:
          dst.RotateFlip(RotateFlipType.Rotate180FlipX);
          break;
        case 5:
          dst.RotateFlip(RotateFlipType.Rotate90FlipX);
          break;
        case 6:
          dst.RotateFlip(RotateFlipType.Rotate270FlipNone);
          break;
        case 7:
          dst.RotateFlip(RotateFlipType.Rotate270FlipX);
          break;
        case 8:
          dst.RotateFlip(RotateFlipType.Rotate90FlipNone);
          break;
      }
    }

    private void SetOrientationAttribute(int i, Image dst)
    {
      PropertyItem orientationAttribute;

      orientationAttribute = (PropertyItem)typeof(PropertyItem).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, CallingConventions.Any, new Type[0], null).Invoke(null);

      orientationAttribute.Id = ImageExtensions.ExifOrientationTagId;
      orientationAttribute.Value = new byte[]
                                   {
                                     (byte)i, 0
                                   };
      orientationAttribute.Len = 2;
      orientationAttribute.Type = 3;

      dst.SetPropertyItem(orientationAttribute);
    }

    #endregion
  }
}
