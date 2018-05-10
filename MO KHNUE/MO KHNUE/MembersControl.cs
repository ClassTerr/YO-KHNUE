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
        }

        private void memberBlocksList1_MemberChanged(Member currentMember)
        {
            memberInfoControl1.InitMember(currentMember);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
