using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MO_KHNUE.Theme;

namespace MO_KHNUE.Design
{
    public class SolidComponent : UserControl
    {
        public SolidComponent()
        {
            ForeColor = ActiveTextColor;
            BackColor = DefaultElementBackgorundColor;
            AutoScaleMode = AutoScaleMode.None;
            SetEvents(this);
        }

        public event EventHandler CustomMouseEnter;
        public event EventHandler CustomMouseLeave;
        public event Action CustomMouseClick;
        public event Action CustomMouseDoubleClick;

        private void SetEvents(Control target)
        {
            ControlAdded += new ControlEventHandler(Form_ControlAdded);
            ControlRemoved += new ControlEventHandler(Form_ControlRemoved);
            MouseEnter += new EventHandler(Control_MouseEnter);
            MouseLeave += new EventHandler(Control_MouseLeave);
        }

        void Form_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseEnter += new EventHandler(Control_MouseEnter);
            e.Control.MouseLeave += new EventHandler(Control_MouseLeave);
            e.Control.MouseClick += new MouseEventHandler(Control_MouseClick);
            e.Control.MouseDoubleClick += new MouseEventHandler(Control_MouseDoubleClick);
        }

        void Form_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.MouseEnter -= new EventHandler(Control_MouseEnter);
            e.Control.MouseLeave -= new EventHandler(Control_MouseLeave);
            e.Control.MouseClick -= new MouseEventHandler(Control_MouseClick);
            e.Control.MouseDoubleClick -= new MouseEventHandler(Control_MouseDoubleClick);
        }

        private bool selectable;
        public bool Selectable
        {
            get
            {
                return selectable;
            }
            set
            {
                selectable = value;
                if (!selectable)
                    Selected = false;
            }
        }

        private bool selected;
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                if (selected)
                {
                    BorderStyle = BorderStyle.FixedSingle;
                    ForeColor = DownTextColor;
                    BackColor = AccentElementBackgorundColor;
                }
                else
                {
                    BorderStyle = BorderStyle.None;
                    ForeColor = DefaultElementForeColor;
                    BackColor = DefaultElementBackgorundColor;
                }
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (!selected)
            {
                ForeColor = HoveredDefaultElementForeColor;
                BackColor = HoveredDefaultElementBackgorundColor;
            }
            CustomMouseEnter?.Invoke(sender, e);
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
            {
                ForeColor = DefaultElementForeColor;
                BackColor = DefaultElementBackgorundColor;
            }
            else
            {
                ForeColor = DownTextColor;
                BackColor = AccentElementBackgorundColor;
            }
            CustomMouseLeave?.Invoke(sender, e);
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (selected)
            {
                ForeColor = DownTextColor;
                BackColor = AccentElementBackgorundColor;
            }
            CustomMouseClick?.Invoke();
        }

        private void Control_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selected)
            {
                ForeColor = DownTextColor;
                BackColor = AccentElementBackgorundColor;
            }
            CustomMouseDoubleClick?.Invoke();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SolidComponent
            // 
            this.Name = "SolidComponent";
            this.ResumeLayout(false);

        }
    }
}
