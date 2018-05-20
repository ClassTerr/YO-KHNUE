using Borderless.Buttons;
using MO_KHNUE.Controllers;
using MO_KHNUE.Design;
using MO_KHNUE.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MO_KHNUE
{
    public partial class BlocksList<T> : UserControl where T : class
    {
        public event BlockValueChangedHandler<T> BlockClicked;
        public event BlockValueChangedHandler<T> ItemRemoveButtonClick;
        public event BlockValueChangedHandler<T> ItemEditButtonClick;
        public event BlockValueChangedHandler<T> ItemAddButtonClick;

        public Type BlockType = null;

        public bool WithControlPanel { get => controlPanel.Visible; set => controlPanel.Visible = value; }

        List<T> Values { get; set; } = new List<T>();

        public bool OnTypeSearch { get; set; } = true;

        public BlocksList()
        {
            var t = typeof(T);
            if (t == typeof(Member))
                BlockType = typeof(MemberBlock);
            if (t == typeof(Department))
                BlockType = typeof(DepartmentBlock);

            InitializeComponent();
            InitTable();
            controlPanel.BackColor = Theme.HoveredDefaultElementBackgorundColor;
            CreateButton("", val =>
            {
                ItemAddButtonClick?.Invoke(GetSelectedValue());
            });
            CreateButton("", val =>
            {
                ItemRemoveButtonClick?.Invoke(GetSelectedValue());
            });
            CreateButton("", val =>
            {
                ItemEditButtonClick?.Invoke(GetSelectedValue());
            });
        }

        private bool selectable = true;
        public bool Selectable
        {
            get
            {
                return selectable;
            }
            set
            {
                selectable = value;
                for (int i = 0; i < table.Controls.Count; i++)
                {
                    if (table.Controls[i] is Block<T> block)
                        block.Selectable = selectable;
                }
                if (!selectable)
                    ClearSelection();
            }
        }
        //public TableLayoutPanel table = new TableLayoutPanel();

        void InitTable()
        {
            table.Click += (s, e) => ClearSelection();
            table.BackColor = Theme.DefaultBackgorundColor;
            table.ControlAdded += new ControlEventHandler(tableLayoutPanel1_ControlAdded);
            table.BringToFront();
        }

        public void ClearSelection()
        {
            foreach (var item in table.Controls)
            {
                if (item is Block<T> mblk)
                {
                    mblk.Selected = false;
                }
            }
        }

        public Block<T> GetSelectedBlock()
        {
            foreach (var item in table.Controls)
            {
                if (item is Block<T> mblk)
                {
                    if (mblk.Selected)
                        return mblk;
                }
            }
            return null;
        }
        public T GetSelectedValue()
        {
            foreach (var item in table.Controls)
            {
                if (item is Block<T> mblk)
                {
                    if (mblk.Selected)
                        return mblk.Value;
                }
            }
            return null;
        }

        public void RemoveValue(T value)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if ((Controls[i] as Block<T>)?.Value == value)
                {
                    Controls.RemoveAt(i);
                    return;
                }
            }
            Values.Remove(value);
        }
        public void ClearValues()
        {
            table.Controls.Clear();
            Values.Clear();
        }

        public void SetValues(List<T> values)
        {
            ClearValues();
            AddValues(values);
        }

        public void AddValues(List<T> values)
        {
            Block<T>[] blocks = new Block<T>[values.Count];
            for (int i = 0; i < values.Count; i++)
            {
                blocks[i] = CreateBlock(values[i]);
            }
            table.Controls.AddRange(blocks);
            Values.AddRange(values);
        }

        public void AddValue(T value)
        {
            table.Controls.Add(CreateBlock(value));
            Values.Add(value);
        }

        public Block<T> CreateBlock(T value)
        {
            if (BlockType == null)
                throw new TypeLoadException();


            var block = BlockType.GetConstructor(new Type[] { typeof(T) }).Invoke(new object[] { value }) as Block<T>;

            block.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            block.Selectable = selectable;
            

            block.CustomMouseClick += (s, e) =>
            {
                BlockClicked?.Invoke(block.Value);
                if (!selectable)
                    return;

                foreach (var item in table.Controls)
                {
                    if (item is Block<T> mblk)
                    {
                        mblk.Selected = false;
                    }
                }
                block.Selected = true;
            };
            return block;
        }

        private int minItemWidth = 400;

        public int MinItemSize
        {
            get { return minItemWidth; }
            set
            {
                Form_Resize(null, null);
                minItemWidth = Math.Max(1, value);
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            table.ColumnCount = Math.Max(1, Math.Min(Values.Count, table.ClientSize.Width / MinItemSize));
        }

        private void tableLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is Block<T> block)
            {
                block.Click += (s, a) => BlockClicked(block.Value);
            }
            Form_Resize(null, null);
        }

        private void addValueButton_Click(object sender, EventArgs e)
        {
            ItemAddButtonClick?.Invoke(null);
        }

        private void removeValueButton_Click(object sender, EventArgs e)
        {
            ItemRemoveButtonClick?.Invoke(GetSelectedValue());
        }

        private void searchBoxTyped(object sender, EventArgs e)
        {
            if (!OnTypeSearch)
                return;

            FilterList(searchField.Text);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FilterList(searchField.Text);
        }

        public void FilterList(string text)
        {
            foreach (var item in table.Controls)
            {
                if (item is ISearchable block && item is Control ctrl)
                {
                    ctrl.Visible = block.IsMatches(text);
                }
            }
        }

        public IconButton CreateButton(string text, BlockValueChangedHandler<T> onClick)
        {
            IconButton button = new IconButton
            {
                Dock = DockStyle.Left,
                Text = text
            };
            button.Click += (s, e) => onClick?.Invoke(GetSelectedValue());
            toolbox.Controls.Add(button);
            button.BringToFront();
            return button;
        }
    }
}
