using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borderless.Buttons;
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
            IconButton addButton = CreateButton("", current =>
            {
                MessageBox.Show("add");
            });
            IconButton removeButton = CreateButton("", current =>
            {
                MessageBox.Show("rem");
            });
        }
    }
}
