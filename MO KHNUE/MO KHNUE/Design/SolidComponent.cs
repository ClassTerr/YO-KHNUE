using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MO_KHNUE.Design
{
    public class SolidComponent : UserControl
    {
        public SolidComponent()
        {
            SetEvents(this);
        }

        public event EventHandler CustomMouseEnter;
        public event EventHandler CustomMouseLeave;
        public event EventHandler CustomMouseClick;

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
        }

        void Form_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.MouseEnter -= new EventHandler(Control_MouseEnter);
            e.Control.MouseLeave -= new EventHandler(Control_MouseLeave);
            e.Control.MouseClick -= new MouseEventHandler(Control_MouseClick);
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            CustomMouseEnter?.Invoke(sender, e);
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            CustomMouseLeave?.Invoke(sender, e);
        }

        private void Control_MouseClick(object sender, EventArgs e)
        {
            CustomMouseClick?.Invoke(sender, e);
        }
    }
}
