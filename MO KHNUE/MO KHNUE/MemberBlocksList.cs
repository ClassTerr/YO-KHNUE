using MO_KHNUE.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MO_KHNUE
{
    public partial class MemberBlocksList : UserControl
    {
        public delegate void MemberChangedHandler(Member currentMember);
        public new event MemberChangedHandler MemberChanged;

        public MemberBlocksList()
        {
            InitializeComponent();
            InitTable();
        }

        public TableLayoutPanel table = new TableLayoutPanel();

        void InitTable()
        {
            table.AutoScroll = true;
            table.ColumnCount = 4;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.Dock = DockStyle.Fill;
            BackColor = Theme.DefaultBackgorundColor;
            table.ControlAdded += new ControlEventHandler(tableLayoutPanel1_ControlAdded);
            Controls.Add(table);
        }

        public void SetMembers(List<Member> members)
        {
            table.Controls.Clear();
            AddMembers(members);
        }

        public void AddMembers(List<Member> members)
        {
            MemberBlock[] blocks = new MemberBlock[members.Count];
            for (int i = 0; i < members.Count; i++)
            {
                var block = new MemberBlock(members[i])
                {
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                    MaximumSize = new System.Drawing.Size(0, 50)
                };

                block.CustomMouseClick += (s, e) =>
                {
                    MemberChanged?.Invoke(block.CurrentMember);
                    ;
                };

                blocks[i] = block;
            }
            table.Controls.AddRange(blocks);
        }

        public void AddMember(Member member)
        {
            var block = new MemberBlock(member)
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                MaximumSize = new System.Drawing.Size(0, 50)
            };
            table.Controls.Add(block);
        }

        public MemberBlock RemoveMember(Member member)
        {
            for (int i = 0; i < table.Controls.Count; i++)
            {
                var item = table.Controls[i];
                if (item is MemberBlock block)
                {
                    if (block.CurrentMember == member)
                    {
                        table.Controls.RemoveAt(i);
                        return block;
                    }
                }
            }
            return null;
        }

        private int minItemSize = 300;

        public int MinItemSize
        {
            get { return minItemSize; }
            set
            {
                Form_Resize(null, null);
                minItemSize = Math.Max(1, value);
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            MemberBlock b = new MemberBlock();
            table.Controls.Add(b);
            //tableLayoutPanel1.ColumnCount = 1;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            table.ColumnCount = Math.Max(1, Math.Min(table.Controls.Count, table.Width / MinItemSize));
        }

        private void tableLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is MemberBlock block)
            {
                if (FindForm() is MainForm frm)
                {
                    block.Click += (s, a) => frm?.ShowContent(new MemberInfoControl(block.CurrentMember));
                }
            }
            Form_Resize(null, null);
        }
    }
}
