using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Borderless.BorderlessForm;
using static MO_KHNUE.Theme;
using MO_KHNUE;

namespace Borderless.Buttons
{
    public class HeaderButton : Label
    {
        Size buttonSize = SystemInformation.CaptionButtonSize;

        public HeaderButton()
        {
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Dock = DockStyle.Right;
            this.MouseEnter += (s, e) => SetStateColor(MouseState.Hover);
            this.MouseLeave += (s, e) => SetStateColor(MouseState.Normal);
            this.MouseDown += (s, e) => SetStateColor(MouseState.Down);
            this.MouseUp += (s, e) => SetStateColor(MouseState.Hover);
            this.Font = new Font("Marlett", 8.5f);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = buttonSize;
        }
        protected void SetStateColor(MouseState state)
        {
            var textColor = FindForm()?.ContainsFocus != true ? InactiveTextColor : ActiveTextColor;
            Color dark = ControlPaint.Dark(textColor, 30);
            var backColor = Theme.DefaultBackgorundColor;

            switch (state)
            {
                case MouseState.Hover:
                    textColor = HoverTextColor;
                    backColor = HoverBackColor;
                    break;
                case MouseState.Down:
                    textColor = DownTextColor;
                    backColor = DownBackColor;
                    break;
                case MouseState.Normal:
                    break;
            }

            this.ForeColor = textColor;
            this.BackColor = backColor;
        }

    }
}
