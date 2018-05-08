using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MO_KHNUE.Properties;

namespace MO_KHNUE
{
    public partial class MainForm : Borderless.BorderlessForm
    {
        public static MainForm instance = null;
        private Point startPoint = new Point(0, 0);
        public Stack<Form> windowsStack = new Stack<Form>();

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            InitMenu(null, null);
            this.BackButton.Click += (s, a) => BackButtonClick();
        }

        void InitMenu(object sender, EventArgs e)
        {
            for (int i = 0; i < menuPanel.Controls.Count; i++)
            {
                Control item = menuPanel.Controls[i];

                Padding pad = menuPanel.Padding;
                int targetSize = menuPanel.Width - pad.Left - pad.Right;
                item.Size = new Size(targetSize, targetSize);
                item.Left = pad.Left;
                item.Top = item.Padding.Top * (i + 1) + i * item.Padding.Bottom + i * targetSize;
            }
        }

        void InitButtonEffects(Control c, Color col)
        {
            Color dark = ControlPaint.Dark(col, 30);

            c.MouseEnter += (s, e) => (s as Control).BackColor = col;
            c.MouseLeave += (s, e) => (s as Control).BackColor = Color.Transparent;
            c.MouseDown += (s, e) => (s as Control).BackColor = dark;
            c.MouseUp += (s, e) => (s as Control).BackColor = col;
        }

        public void ShowForm(Form form)
        {
            form.TopLevel = false;
            controlPanel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
            windowsStack.Push(form);
        }

        public void CloseForm(Form form)
        {
            form.Close();
            controlPanel.Controls.Remove(form);
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(3, 131, 135);
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Transparent;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {

            ClearWindows();

            ShowForm(new OverviewForm());
        }

        public void ClearWindows()
        {
            while (windowsStack.Count > 0)
            {
                controlPanel.Controls.Remove(windowsStack.Pop());
            }
        }

        private void BackButtonClick()
        {
            if (windowsStack.Count == 0)
                return;

            var form = windowsStack.Pop();
            CloseForm(form);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ClearWindows();

            ShowForm(new DepartmentForm());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
