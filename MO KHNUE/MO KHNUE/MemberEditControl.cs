using MO_KHNUE.Design;
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
    public partial class MemberEditControl : Form, ICloseQuery
    {
        private Member member = null;
        private bool edited = false;
        public MemberEditControl()
        {
            InitializeComponent();
            InitEvents();
        }

        public MemberEditControl(Member member)
        {
            InitializeComponent();
            InitMember(member);
            InitEvents();
        }

        private void InitEvents()
        {
            outputBirthDay.ValueChanged += new System.EventHandler(Edited);
            outputEmail.TextChanged += new System.EventHandler(Edited);
            outputPhone.TextChanged += new System.EventHandler(Edited);
            outputGroup.TextChanged += new System.EventHandler(Edited);
            outputName.TextChanged += new System.EventHandler(Edited);
            outputSurname.TextChanged += new System.EventHandler(Edited);
            outputCourse.TextChanged += new System.EventHandler(Edited);
        }

        public event BlockValueChangedHandler<Member> MemberChanged;

        public void ClearInfo()
        {
            iconButton2.Text = outputEmail.Text = outputGroup.Text = outputName.Text = outputPhone.Text = outputSurname.Text = outputCourse.Text = "";
            photo.Image = Resources.UserImagePlaceholder;
        }

        public void InitMember(Member member)
        {
            this.member = member;
            if (member == null)
            {
                ClearInfo();
                return;
            }

            outputBirthDay.Value = member.BirthDay;
            outputEmail.Text = member.Email;
            outputGroup.Text = member.Group;
            outputName.Text = member.Name;
            outputPhone.Text = member.Phone;
            outputSurname.Text = member.Surname;
            outputCourse.Text = member.Course.ToString();

            if (member.Photo == null)
                photo.Image = Utils.ClipToCircle(Resources.UserImagePlaceholder);
            else photo.Image = Utils.ClipToCircle(member.Photo);
        }

        private void Close(object sender, EventArgs e)
        {
            TryClose();
        }

        private void Apply(object sender, EventArgs e)
        {
            try
            {
                member.Course = int.Parse(outputCourse.Text);
                member.BirthDay = outputBirthDay.Value;
                member.Group = outputGroup.Text;
                member.Name = outputName.Text;
                member.Surname = outputSurname.Text;
                member.Phone = outputPhone.Text;
                member.Email = outputEmail.Text;
                MemberChanged?.Invoke(member);
                edited = false;
                Close(sender, e);
            }
            catch
            {
                outputCourse.BackColor = Color.Red;
            }
        }

        public void TryClose()
        {
            if (!edited || MessageBox.Show("Все изменения сохраниены не будут\nВы действительно хотите вернуться?",
                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MainForm.instance.CloseContent(this);
            }
        }

        private void Edited(object sender, EventArgs e)
        {
            edited = true;
        }
    }
}
