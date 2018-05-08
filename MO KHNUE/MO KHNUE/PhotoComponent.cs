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

namespace MO_KHNUE
{
    public partial class PhotoComponent : UserControl
    {
        public PhotoComponent()
        {
            bool sizeChanging = false;
            InitializeComponent();
            SizeChanged += (o, e) =>
            {
                if (sizeChanging)
                    return;

                sizeChanging = true;
                Width = Height;
                sizeChanging = false;
            };
        }

        public void SetImageRaw(Image value)
        {
            pictureBox1.Image = value;
        }

        public void SetImage(Image value, PointF center, float radius)
        {
            if (value != null)
            {
                pictureBox1.Image = ClipToCircle(value, center, radius, Color.Transparent);
            }
            else
            {
                pictureBox1.Image = Resources.UserImagePlaceholder;
            }
        }

        public void SetImage(Image value)
        {
            if (value != null)
            {
                pictureBox1.Image = ClipToCircle(value);
            }
            else
            {
                pictureBox1.Image = Resources.UserImagePlaceholder;
            }
        }

        public Image GetImage()
        {
            return pictureBox1.Image;
        }
    }
}
