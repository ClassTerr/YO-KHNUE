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

        public event BlockValueChangedHandler<Member> MemberChanged;

        public MemberInfoControl(Member member)
        {
            InitializeComponent();
            headPanel.BackColor = AccentElementBackgorundColor;

            InitMember(member);
        }

        public void ClearInfo()
        {
            outputBirthDay.Text = outputEmail.Text = outputGroup.Text = outputName.Text
                = outputPhone.Text = outputCource.Text = "";
            photo.Image = Resources.UserImagePlaceholder;
            editButton.Visible = iconButtonSmall1.Visible = iconButtonSmall2.Visible =
                iconButtonSmall3.Visible = iconButtonSmall4.Visible = iconButtonSmall6.Visible = iconButtonSmall5.Visible = false;
        }

        public void InitMember(Member member)
        {
            _member = member;
            if (member == null)
            {
                ClearInfo();
                return;
            }

            editButton.Visible = iconButtonSmall1.Visible = iconButtonSmall2.Visible =
                iconButtonSmall3.Visible = iconButtonSmall4.Visible = iconButtonSmall6.Visible = iconButtonSmall5.Visible = true;

            outputBirthDay.Text = member.BirthDay.ToShortDateString();
            outputEmail.Text = member.Email;
            outputGroup.Text = member.Group;
            outputName.Text = member.FullName;
            outputPhone.Text = member.Phone;
            outputCource.Text = member.Course.ToString() + " курс";

            /*if (member.Photo == null)
                photo.Image = Utils.ClipToCircle(Resources.UserImagePlaceholder);
            else photo.Image = Utils.ClipToCircle(member.Photo);*/
            photo.Image = Resources.UserImagePlaceholder;
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            var control = new MemberEditControl(_member);
            control.MemberChanged += (member) =>
            {
                try
                {
                    Database.DBContext.CurrentContext.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изменения!");
                }
                InitMember(member);
                MemberChanged?.Invoke(member);
            };
            MainForm.instance.ShowContent(control);
        }
    }
}
