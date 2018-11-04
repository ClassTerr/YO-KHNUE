using MO_KHNUE.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MO_KHNUE.Database.RedisDatabase;

namespace MO_KHNUE.Database
{
    public class DBContext
    {
        public List<Member> Members { get; set; }
        public List<Department> Departments { get; set; }

        private static DBContext context = null;

        public void SaveChanges()
        {
            SetValue("Context", this);
        }


        public static DBContext CurrentContext
        {
            get
            {
                if (context == null)
                    context = UpdateDbContext();

                return context;
            }
        }

        private static DBContext LoadDBContext()
        {
            string val = GetValue("Context");

            if (val != null)
            {
                context = JsonConvert.DeserializeObject<DBContext>(val);
            }
            else
            {
                context = new DBContext(true);
            }

            if (context == null)
            {
                throw new JsonException("Cannot get context");
            }

            return context;
        }

        public static DBContext UpdateDbContext()
        {
            DBContext context = null;
            try
            {
                context = LoadDBContext();
            }
            catch (JsonException)
            {
                MessageBox.Show("База данных повреждена!");
            }
            finally
            {
                if (context == null)
                {
                    Console.Error.Write("Can't connect to database!");

                    context = new DBContext(true);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Не удаётся соезиниться с базой данных!");
                    }
                }
            }

            return context;
        }

        public DBContext(bool autoinit = false)
        {
            if (Members == null)
                Members = new List<Member>();
            if (Departments == null)
                Departments = new List<Department>();
            if (autoinit)
                DBSeed.Seed(this);
        }
    }
}
