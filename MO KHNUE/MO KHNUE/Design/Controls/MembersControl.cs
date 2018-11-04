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
using MO_KHNUE.Database;

namespace MO_KHNUE
{
    public partial class MembersControl : Form
    {
    public MembersControl()
    {
        InitializeComponent();

        InitControl(DBContext.UpdateDbContext().Members);
        memberInfoControl1.MemberChanged += (member) =>
        {
            InitControl(DBContext.CurrentContext.Members);
        };
    }

        public void InitControl(List<Member> members)
        {
            memberBlocksList1.SetValues(members);
            memberInfoControl1.InitMember(null);
        }

        private void memberBlocksList1_MemberChanged(Member currentMember)
        {
            memberInfoControl1.InitMember(currentMember);
        }

        private void AddMember(Member curentMember)
        {
            var newMember = new Member();
            MemberEditControl editControl = new MemberEditControl(newMember);
            editControl.MemberChanged += (mem) =>
            {
                var context = DBContext.CurrentContext;
                context.Members.Add(newMember);
                context.SaveChanges();
                InitControl(context.Members);
            };
            MainForm.instance.ShowContent(editControl);
        }

        private void RemoveMember(Member member)
        {
            if (member == null)
                return;

            if (MessageBox.Show("Вы действительно хотите удалить из членов МО " + 
                member.FullName + "?", 
                "Подтверждение", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Exclamation) ==
                DialogResult.OK)
            {
                var db = Database.DBContext.UpdateDbContext();
                int ind = db.Members.IndexOf(member);
                if (ind == -1)
                {
                    MessageBox.Show("Не удалось удалить...");
                }
                else
                {
                    db.Members.RemoveAt(ind);
                    db.SaveChanges();
                    InitControl(DBContext.UpdateDbContext().Members);
                }
            }
        }
    }
}
