using static MO_KHNUE.Database.DBContext;
using MO_KHNUE.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MO_KHNUE
{
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            var departments = UpdateDbContext().Departments;
            departmentBlockList1.SetValues(departments);
            departmentBlockList1.OneColumn = true;
            //departmentBlockList1.table.Dock = DockStyle.Left;
            //departmentBlockList1.table.Width = 500;

            departmentBlockList1.MenuAddButtonClick += AddClick;
            departmentBlockList1.MenuRemoveButtonClick += RemoveClick;
            departmentBlockList1.MenuEditButtonClick += EditClick;
            departmentBlockList1.MenuDetailsButtonClick += DetailsClick;
            departmentBlockList1.BlockDoubleClicked += DetailsClick;
            departmentBlockList1.BlockClicked += LoadBlock;
            departmentBlockList1.Click += (o, e) => { departmentInfoControl1.InitDepartment(null); };

            departmentInfoControl1.InitDepartment(null);
        }

        private void AddClick(Department selected)
        {
            //создание нового отдела
        }

        private void RemoveClick(Department selected)
        {
            //удаление отдела
            var res = MessageBox.Show("Вы действительно хотите удалить отдел \"" + selected.FullName + "\" из МО?\nЭто действие отменить невозможно.", "Подтверждение", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                var context = UpdateDbContext();
                context.Departments.Remove(selected);
                context.SaveChanges();
                departmentBlockList1.SetValues(context.Departments);
            }
        }

        private void EditClick(Department selected)
        {
            //изменение отдела
        }

        private void DetailsClick(Department selected)
        {
            Utils.ShowContent(new DepartmentControl(selected));
        }

        private void LoadBlock(Department selected)
        {
            departmentInfoControl1.InitDepartment(selected);
        }
    }
}
