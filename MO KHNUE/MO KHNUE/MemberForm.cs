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
    public partial class MemberForm : Form
    {
        private Member _member = null;
        public MemberForm()
        {
            InitializeComponent();
        }

        public MemberForm(Member member)
        {
            InitializeComponent();
            InitMember(member);
        }

        public void ClearInfo()
        {
            outputBirthDay.Text = outputEmail.Text = outputGroup.Text = outputName.Text = outputPhone.Text = outputSurname.Text = "";
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
        }
    }
}
