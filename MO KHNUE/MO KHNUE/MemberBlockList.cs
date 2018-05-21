using MO_KHNUE.Entities;

namespace MO_KHNUE
{
    public partial class MemberBlockList : BlocksList<Member>
    {
        public MemberBlockList()
        {
            InitializeComponent();
            InitToolbox();
        }

        void InitToolbox()
        {
            AddButton.Text = "";
            RemoveButton.Text = "";
        }
    }
}
