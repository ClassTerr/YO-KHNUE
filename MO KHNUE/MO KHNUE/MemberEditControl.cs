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

namespace MO_KHNUE.Entities
{
    public partial class MemberControl : UserControl
    {
        private Member _member = null;
        public MemberControl()
        {
            InitializeComponent();
        }

        public MemberControl(Member member)
        {
            InitializeComponent();
            InitMember(member);
        }

        public void ClearInfo()
        {
            outputBirthDay.Text = outputEmail.Text = outputGroup.Text = outputName.Text = outputPhone.Text = outputSurname.Text = "";
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
            outputName.Text = member.Name;
            outputPhone.Text = member.Phone;
            outputSurname.Text = member.Surname;

            if (member.Photo == null)
                photo.Image = Utils.ClipToCircle(Resources.UserImagePlaceholder);
            else photo.Image = Utils.ClipToCircle(member.Photo);
        }
    }
}
