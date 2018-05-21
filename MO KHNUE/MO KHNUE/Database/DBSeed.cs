using MO_KHNUE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE.Database
{
    public static class DBSeed
    {
        public static void Seed(DBContext db)
        {
            var artem = new Member()
            {
                Name = "Artem",
                Surname = "Balyanitsa",
                Course = 3,
                Email = "artemium97@gmail.com",
                Phone = "380958338701",
                Group = "6.04.51.15.01",
                BirthDay = new DateTime(1997, 5, 30)
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
                FullName = "Project Management",
                Head = artem
            };

            pm.Members.Add(ann);
            pm.Members.Add(kasper);

            var pr = new Department()
            {
                Name = "PR",
                FullName = "Public Relations",
                Head = ann
            };

            pr.Members.Add(artem);

            db.Members.Add(ann);
            db.Members.Add(artem);
            db.Members.Add(kasper);


            db.Departments.Add(pm);
            db.Departments.Add(pr);
        }
    }
}
