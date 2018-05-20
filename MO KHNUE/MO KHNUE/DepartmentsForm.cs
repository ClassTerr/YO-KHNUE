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
            var departments = Database.DBContext.UpdateDbContext().Departments;

            DepartmentBlock[] blocks = new DepartmentBlock[departments.Count];
            for (int i = 0; i < departments.Count; i++)
            {
                var currentBlock = new DepartmentBlock(departments[i]);
                currentBlock.CustomMouseClick += (s, e) =>
                {
                    MainForm.instance.ShowContent(new DepartmentControl(currentBlock.Value));
                };
                currentBlock.Dock = DockStyle.Top;
                blocks[i] = currentBlock;
            }
            /*
            departmentsFlowLayout.Controls.Clear();
            departmentsFlowLayout.Controls.AddRange(blocks);*/
        }

        public DepartmentsForm(Department department)
        {
            InitializeComponent();
        }
    }
}
