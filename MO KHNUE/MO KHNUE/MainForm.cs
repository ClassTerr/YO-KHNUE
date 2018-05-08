﻿using System;
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
        public Stack<Control> contentStack = new Stack<Control>();

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            this.BackButton.Click += (s, a) => BackButtonClick();
        }

        public void ShowContent(Control contentControl)
        {
            if (contentControl is Form frm)
            {
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            controlPanel.Controls.Add(contentControl);
            contentControl.Dock = DockStyle.Fill;
            contentControl.Show();
            contentControl.BringToFront();
            contentStack.Push(contentControl);
        }

        public void CloseContent(Control control)
        {
            controlPanel.Controls.Remove(control);
            if (control is Form frm)
            {
                frm.Close();
            }

            control.Visible = false;
            control.Dispose();
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

            ShowContent(new OverviewForm());
        }

        public void ClearWindows()
        {
            while (contentStack.Count > 0)
            {
                controlPanel.Controls.Remove(contentStack.Pop());
            }
        }

        private void BackButtonClick()
        {
            if (contentStack.Count == 0)
                return;

            var form = contentStack.Pop();
            CloseContent(form);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ClearWindows();

            ShowContent(new DepartmentForm());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            ShowContent(new MembersControl());
        }
    }
}
