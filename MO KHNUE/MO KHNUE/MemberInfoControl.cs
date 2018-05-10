using MO_KHNUE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MO_KHNUE.Theme;

namespace MO_KHNUE.Entities
{
    public partial class MemberInfoControl : UserControl
    {
        private Member _member = null;
        public MemberInfoControl()
        {
            InitializeComponent();
            headPanel.BackColor = AccentElementBackgorundColor;
        }

        public MemberInfoControl(Member member)
        {
            InitializeComponent();
            headPanel.BackColor = AccentElementBackgorundColor;

            InitMember(member);
        }

        public void ClearInfo()
        {
            outputBirthDay.Text = outputEmail.Text = outputGroup.Text = outputName.Text = outputPhone.Text = "";
            photo.Image = Resources.UserImagePlaceholder;
        }

        public void InitMember(Member member)
        {
            _member = member;
            if (member == null)
            {
                ClearInfo();
                return;
            }

            outputBirthDay.Text = member.BirthDay.ToShortDateString();
            outputEmail.Text = member.Email;
            outputGroup.Text = member.Group;
            outputName.Text = member.Name + " " + member.Surname;
            outputPhone.Text = member.Phone;

            /*if (member.Photo == null)
                photo.Image = Utils.ClipToCircle(Resources.UserImagePlaceholder);
            else photo.Image = Utils.ClipToCircle(member.Photo);*/
            photo.Image = Resources.UserImagePlaceholder;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MainForm.instance.ShowContent(new MemberControl(_member));
        }
    }
}
