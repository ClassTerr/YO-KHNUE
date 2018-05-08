using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borderless.Buttons;
using Borderless;

namespace MO_KHNUE
{
    public partial class IconButtonSmall : IconButton
    {
        public IconButtonSmall()
        {
            Font = UIFont.GetUIFont(20);
        }
    }
}
