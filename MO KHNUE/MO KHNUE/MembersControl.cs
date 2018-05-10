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
    public partial class MembersControl : UserControl
    {
        public MembersControl()
        {
            InitializeComponent();

            toolbox.BackColor = Theme.HoveredDefaultElementBackgorundColor;

            InitControl(Database.DBContext.UpdateDbContext().Members);
        }

        public void InitControl(List<Member> members)
        {
            memberBlocksList1.SetMembers(members);
            memberInfoControl1.InitMember(null);
        }

        private void memberBlocksList1_MemberChanged(Member currentMember)
        {
            memberInfoControl1.InitMember(currentMember);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var sel = memberBlocksList1.GetSelectedBlock();
            if (sel == null)
                return;

            if (MessageBox.Show("Вы действительно хотите удалить из членов МО " + 
                sel.CurrentMember.FullName + "?", 
                "Подтверждение", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Exclamation) ==
                DialogResult.OK)
            {
                var db = Database.DBContext.UpdateDbContext();
                int ind = db.Members.IndexOf(sel.CurrentMember);
                if (ind == -1)
                {
                    MessageBox.Show("Не удалось удалить...");
                }
                else
                {
                    db.Members.RemoveAt(ind);
                    db.SaveChanges();
                    InitControl(Database.DBContext.UpdateDbContext().Members);
                }
            }
        }
    }
}
