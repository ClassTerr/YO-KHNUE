using Borderless.Buttons;
using MO_KHNUE;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static Borderless.BorderlessForm;
using static MO_KHNUE.Theme;

namespace Borderless.Buttons
{
    public class IconButton : Label
    {

        public IconButton()
        {
            Font = UIFont.GetUIFont();
            Dock = DockStyle.None;
            AutoSize = true;
            TextAlign = ContentAlignment.MiddleCenter;
            DeativateOnIdle = false;
            this.MouseEnter += (s, e) => SetStateColor(MouseState.Hover);
            this.MouseLeave += (s, e) => SetStateColor(MouseState.Normal);
            this.MouseDown += (s, e) => SetStateColor(MouseState.Down);
            this.MouseUp += (s, e) => SetStateColor(MouseState.Hover);
        }

        protected void SetStateColor(MouseState state)
        {
            var textColor = DeativateOnIdle ? InactiveTextColor : ActiveTextColor;
            Color dark = ControlPaint.Dark(textColor, 30);

            switch (state)
            {
                case MouseState.Hover:
                    textColor = HoverBackColor;
                    break;
                case MouseState.Down:
                    textColor = DownBackColor;
                    break;
            }

            this.ForeColor = textColor;
        }

        private bool deativateOnIdle = false;

        [EditorBrowsable]
        [DefaultValue(false)]
        public bool DeativateOnIdle
        {
            get
            {
                return deativateOnIdle;
            }
            set
            {
                deativateOnIdle = value;
                this.ForeColor = ActiveTextColor;
            }
        }
    }
}