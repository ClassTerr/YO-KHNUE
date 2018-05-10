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

namespace MO_KHNUE
{
    public partial class MemberBlock : SolidComponent
    {
        public Member CurrentMember { get; set; }
        public new event EventHandler CustomMouseClick;

        public MemberBlock()
        {
            CustomMouseEnter += Control_MouseEnter;
            CustomMouseLeave += Control_MouseLeave;
            base.CustomMouseClick += Control_MouseClick;

            InitializeComponent();

            ForeColor = ActiveTextColor;
            BackColor = DefaultElementBackgorundColor;
        }
        public MemberBlock(Member member)
        {
            CustomMouseEnter += Control_MouseEnter;
            CustomMouseLeave += Control_MouseLeave;
            base.CustomMouseClick += Control_MouseClick;

            InitializeComponent();

            ForeColor = ActiveTextColor;
            BackColor = DefaultElementBackgorundColor;
            InitMember(member);
        }

        public void InitMember(Member member)
        {
            CurrentMember = member;
            label1.Text = member.Name + " " + member.Surname;

            Image photo = member.Photo;
            if (photo != null)
                photo = Utils.ClipToCircle(member.Photo);
            photoComponent1.SetImage(photo);
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = HoveredDefaultElementForeColor;
            BackColor = HoveredDefaultElementBackgorundColor;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = DefaultElementForeColor;
            BackColor = DefaultElementBackgorundColor;
        }

        private void Control_MouseClick(object sender, EventArgs e)
        {
            CustomMouseClick?.Invoke(sender, e);
        }
    }
}
