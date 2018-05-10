using System;
using System.Drawing;
using System.Windows.Forms;
using static MO_KHNUE.Database.DBContext;
using MO_KHNUE.Database;

namespace MO_KHNUE
{
    public partial class OverviewForm : Form
    {
        DBContext db = new DBContext();
        public OverviewForm()
        {
            InitializeComponent();
            InitForm(UpdateDbContext());
        }

        private void InitForm(DBContext context)
        {
            var departments = context.Departments;

            foreach (var item in departments)
            {
                Button b = new Button
                {
                    Margin = new Padding(10),
                    Size = new Size(100, 30)
                };

                int count = item.Members.Count;
                if (!item.Members.Contains(item.Head))
                    count++;

                b.Text = $"{item.Name} ({ count } чел.)";

                b.Click += (e, s) =>
                {
                    MainForm.instance.ShowContent(new DepartmentForm(item));
                };

                flowLayoutPanel1.Controls.Add(b);
            }
        }
    }
}
