using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MO_KHNUE
{
    public static class Utils
    {
        public static void ShowContent(Control c)
        {
            MainForm.instance.ShowContent(c);
        }

        // makes nice round ellipse/circle images from rectangle images
        public static Image ClipToCircle(Image srcImage)
        {
            Size sz = srcImage.Size;
            PointF center = new PointF(sz.Width / 2, sz.Height / 2);
            return ClipToCircle(srcImage, center, center.Y, Color.Transparent);
        }

        public static Image ClipToCircle(Image srcImage, PointF center, float radius, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);

            using (Graphics g = Graphics.FromImage(dstImage))
            {
                RectangleF r = new RectangleF(center.X - radius, center.Y - radius,
                                              radius * 2, radius * 2);

                // enables smoothing of the edge of the circle (less pixelated)
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // fills background color
                using (Brush br = new SolidBrush(backGround))
                {
                    g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
                }

                // adds the new ellipse & draws the image again 
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.SetClip(path);
                g.DrawImage(srcImage, 0, 0);
                return dstImage;
            }
        }
    }
}
