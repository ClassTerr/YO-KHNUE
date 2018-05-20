﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MO_KHNUE.Entities;
using Newtonsoft.Json;
using static MO_KHNUE.Database.RedisDatabase;

namespace MO_KHNUE.Database
{
    public class DBContext
    {
        public void SaveChanges()
        {
            //SetValue("Members", Members);
            //SetValue("Departments", Departments);
            SetValue("Context", this);
        }

        private static DBContext _context = null;

        public static DBContext CurrentContext
        {
            get
            {
                if (_context == null)
                    _context = UpdateDbContext();

                return _context;
            }
        }

        private static DBContext LoadDBContext()
        {
            string val = GetValue("Context");

            if (val != null)
            {
                _context = JsonConvert.DeserializeObject<DBContext>(val);
            }
            else
            {
                _context = new DBContext(true);
            }

            if (_context == null)
            {
                throw new JsonException("Cannot get context");
            }

            return _context;
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

        public List<Member> Members { get; set; }
        public List<Department> Departments { get; set; }
    }

}
