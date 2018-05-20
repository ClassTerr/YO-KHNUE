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
using static MO_KHNUE.Theme;
using System.Runtime.InteropServices;
using MO_KHNUE.Design;
using MO_KHNUE.Controllers;

namespace MO_KHNUE
{
    public partial class MemberBlock : Block<Member>, ISearchable, IBlock<Member>
    {
        public override Member Value
        {
            get => base.Value;
            set
            {
                InitValue(value);
            }
        }

        private void Clear()
        {
            label1.Text = "";
            photoComponent1.SetImage(null);
        }

        public MemberBlock()
        {
            InitializeComponent();

            ForeColor = ActiveTextColor;
            BackColor = DefaultElementBackgorundColor;
        }
        public MemberBlock(Member member)
        {
            InitializeComponent();

            ForeColor = ActiveTextColor;
            BackColor = DefaultElementBackgorundColor;
            InitValue(member);
        }

        public void InitValue(Member member)
        {
            base.Value = member;
            if (member == null)
            {
                Clear();
                return;
            }

            label1.Text = member.Name + " " + member.Surname;
            Image photo = member.Photo;
            if (photo != null)
                photo = Utils.ClipToCircle(member.Photo);
            photoComponent1.SetImage(photo);
        }

        public bool IsMatches(string pattern)
        {
            return Value?.IsMatches(pattern) ?? false;
        }
    }
}
