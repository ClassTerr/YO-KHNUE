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

namespace MO_KHNUE
{
    public partial class DepartmentControl : UserControl
    {
        private Department _department = null;
        public DepartmentControl()
        {
            CustomInit();
        }
        public DepartmentControl(Department department)
        {
            CustomInit();
            InitDepartment(department);
        }

        void CustomInit()
        {
            InitializeComponent();
            memberBlocksList1.BlockClicked += (s) => MainForm.instance.ShowContent(new MemberInfoControl(s));
            departmentHeadBlock.CustomMouseClick += (s, e) =>
            {
                MainForm.instance.ShowContent(new MemberInfoControl((s as MemberBlock)?.Value));
            };
            BackColor = Theme.DefaultBackgorundColor;
            memberBlocksList1.Selectable = false;
        }

        public void InitDepartment(Department department)
        {
            _department = department;
            departmentHeadBlock.InitValue(department.Head);
            memberBlocksList1.SetValues(department.Members);
        }
    }
}
