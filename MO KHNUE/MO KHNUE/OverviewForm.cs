using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using static MO_KHNUE.Database;
using StackExchange.Redis;
using MO_KHNUE.Entities;
using MO_KHNUE.Properties;

namespace MO_KHNUE
{
    public partial class OverviewForm : Form
    {
        DBContext db = new DBContext();
        public OverviewForm()
        {

            InitializeComponent();

            var artem = new Member()
            {
                Name = "Artem",
                Surname = "Balyanitsa",
                Course = 3,
                Email = "artemium97@gmail.com",
                Phone = "380958338701",
                Group = "6.04.51.15.01",
                BirthDay = new DateTime(1997, 5, 30),
                Photo = Image.FromFile(@"C:\Users\super\Downloads\Telegram Desktop\boy1-1.png")
            };

            var ann = new Member()
            {
                Name = "Anna",
                Surname = "Nemchenko",
                Course = 3,
                Email = "annnemch11@gmail.com",
                Phone = "380666918286",
                Group = "6.04.51.15.01",
                BirthDay = new DateTime(1998, 9, 11)
            };

            var kasper = new Member()
            {
                Name = "Ярослав",
                Surname = "Касперович",
                Course = 3,
                Email = "kasper@gmail.com",
                Phone = "380999343234",
                Group = "6.04.51.15.01",
                BirthDay = new DateTime(1997, 10, 20)
            };

            var pm = new Department()
            {
                Name = "PM",
                Head = artem
            };

            pm.Members.Add(ann);
            pm.Members.Add(kasper);

            var pr = new Department()
            {
                Name = "PR",
                Head = ann
            };

            pr.Members.Add(artem);

            db.Members.Add(ann);
            db.Members.Add(artem);
            db.Members.Add(kasper);


            db.Departments.Add(pm);
            db.Departments.Add(pr);

            try
            {
                db = DBContext.LoadDBContext();
            }
            catch
            {
                Console.Error.Write("Can't connect to database!");
            }

            db.SaveChanges();

            InitForm(db);
        }

        private void InitForm(DBContext context)
        {
            var departments = context.Departments;

            foreach (var item in departments)
            {
                Button b = new Button();
                b.Margin = new Padding(10);
                b.Size = new Size(100, 30);
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
