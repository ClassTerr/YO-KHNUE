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
using System.Runtime.InteropServices;
using MO_KHNUE.Design;
using MO_KHNUE.Controllers;

namespace MO_KHNUE
{
    public partial class DepartmentBlock : Block<Department>, IBlock<Department>
    {
        public DepartmentBlock()
        {
            InitializeComponent();
        }
        public DepartmentBlock(Department department)
        {
            InitializeComponent();
            InitValue(department);
        }

        public override Department Value
        {
            get => base.Value;
            set
            {
                base.Value = value;
                InitValue(value);
            }
        }

        public void InitValue(Department department)
        {
            base.Value = department;
            label1.Text = department.FullName;


            int count = department.Members.Count;
            if (!department.Members.Contains(department.Head))
                count++;

            countLabel.Text = count.ToString() + " чел";

            Image photo = department.Image;
            if (photo != null)
                photo = Utils.ClipToCircle(department.Image);
            photoComponent1.SetImage(photo);
        }
    }
}
