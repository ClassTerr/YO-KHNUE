using MO_KHNUE.Entities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MO_KHNUE
{
    public partial class DepartmentForm : Form
    {
        private Department _department = null;
        public DepartmentForm()
        {
            InitializeComponent();
        }

        public DepartmentForm(Department department)
        {
            InitializeComponent();
            foreach (var item in department.Members)
            {
                LinkLabel label = new LinkLabel();
                label.Size = new Size(300, 20);
                label.Text = item.Name;
                label.LinkClicked += (s, e) => MainForm.instance.ShowContent(new MemberInfoControl(item));
                membersFlowLayout.Controls.Add(label);

            }
            InitDepartment(department);
        }

        public void InitDepartment(Department department)
        {
            _department = department;
            headLinkLabel.Text = department.Head.Name;
        }

        private void headLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.instance.ShowContent(new MemberInfoControl(_department?.Head));
        }
    }
}
