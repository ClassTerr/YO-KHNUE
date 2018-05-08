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
    public partial class UserBlock : UserControl
    {
        public UserBlock()
        {
            InitializeComponent();
        }
        public UserBlock(Member member)
        {
            InitializeComponent();
        }

        public void InitMember(Member member)
        {
            photoComponent1.SetImage(member.Photo);
            label1.Text = member.Name + " " + member.Surname;
        }
    }
}
