using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MO_KHNUE.Entities;
using static MO_KHNUE.Theme;
using MO_KHNUE.Properties;

namespace MO_KHNUE
{
    public partial class DepartmentInfoControl : UserControl
    {
        private Department department = null;
        public DepartmentInfoControl()
        {
            InitializeComponent();
            headPanel.BackColor = AccentElementBackgorundColor;
        }

        public event BlockValueChangedHandler<Department> DepartmentChanged;

        public DepartmentInfoControl(Department department)
        {
            InitializeComponent();
            headPanel.BackColor = AccentElementBackgorundColor;

            InitDepartment(department);
        }

        public void ClearInfo()
        {
            outputMembersCount.Text = outputName.Text
                = outputLeader.Text = "";
            photo.Image = Resources.UserImagePlaceholder;
            editButton.Visible = iconButtonSmall2.Visible = iconButtonSmall6.Visible = iconButtonSmall5.Visible = false;
        }

        public void InitDepartment(Department department)
        {
            this.department = department;
            if (department == null)
            {
                ClearInfo();
                return;
            }

            editButton.Visible = iconButtonSmall2.Visible = iconButtonSmall6.Visible = iconButtonSmall5.Visible = true;
            
            outputName.Text = department.FullName;
            outputLeader.Text = department.Head.FullName;
            outputMembersCount.Text = department.MembersCount + " участников";

            /*if (department.Photo == null)
                photo.Image = Utils.ClipToCircle(Resources.UserImagePlaceholder);
            else photo.Image = Utils.ClipToCircle(department.Photo);*/
            photo.Image = Resources.UserImagePlaceholder;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var control = new DepartmentControl(department);
            control.DepartmentChanged += (dep) =>
            {
                try
                {
                    Database.DBContext.CurrentContext.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изменения!");
                }
                InitDepartment(dep);
                DepartmentChanged?.Invoke(dep);
            };
            MainForm.instance.ShowContent(control);
        }
    }
}
