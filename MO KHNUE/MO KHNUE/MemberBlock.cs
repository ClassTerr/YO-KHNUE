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

namespace MO_KHNUE
{
    public partial class MemberBlock : UserControl
    {
        public Member CurrentMember { get; set; }

        void Form_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseEnter += new EventHandler(Control_MouseEnter);
            e.Control.MouseLeave += new EventHandler(Control_MouseLeave);
        }

        void Form_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.MouseEnter -= new EventHandler(Control_MouseEnter);
            e.Control.MouseLeave -= new EventHandler(Control_MouseLeave);
        }

        public MemberBlock()
        {
            InitWindow();
            InitializeComponent();
        }
        public MemberBlock(Member member)
        {
            InitWindow();
            InitializeComponent();
        }

        private void InitWindow()
        {
            ControlAdded += new ControlEventHandler(Form_ControlAdded);
            ControlRemoved += new ControlEventHandler(Form_ControlRemoved);
            MouseEnter += new EventHandler(Control_MouseEnter);
            MouseLeave += new EventHandler(Control_MouseLeave);
            ForeColor = ActiveTextColor;
            BackColor = NormalBackColor;
        }

        public void InitMember(Member member)
        {
            CurrentMember = member;
            photoComponent1.SetImage(member.Photo);
            label1.Text = member.Name + " " + member.Surname;
        }
        
        private void Control_MouseEnter(object sender, EventArgs e)
        {
                ForeColor = HoverTextColor;
                BackColor = HoverBackColor;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
                ForeColor = ActiveTextColor;
                BackColor = NormalBackColor;
        }
    }
}
