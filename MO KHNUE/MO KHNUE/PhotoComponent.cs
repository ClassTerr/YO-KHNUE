using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MO_KHNUE.Utils;
using MO_KHNUE.Properties;
using System.Drawing.Drawing2D;

namespace MO_KHNUE
{
    public partial class PhotoComponent : PictureBox
    {
        public PhotoComponent()
        {
            bool sizeChanging = false;
            this.SizeMode = PictureBoxSizeMode.Zoom;
            SizeChanged += (o, e) =>
            {
                if (sizeChanging)
                    return;

                sizeChanging = true;
                Width = Height;
                sizeChanging = false;
            };
        }

        public void SetImage(Image value, PointF center, float radius)
        {
            if (value != null)
            {
                Image = ClipToCircle(value, center, radius, Color.Transparent);
            }
            else
            {
                Image = Resources.UserImagePlaceholder;
            }
        }

        public void SetImage(Image value)
        {
            if (value != null)
            {
                Image = ClipToCircle(value);
            }
            else
            {
                Image = Resources.UserImagePlaceholder;
            }
        }
    }
}
