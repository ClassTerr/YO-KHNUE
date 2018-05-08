using System;
using System.Collections.Generic;
using static MO_KHNUE.Database;
using System.Text;
using System.Threading.Tasks;
using MO_KHNUE.Entities;
using Newtonsoft.Json;

namespace MO_KHNUE
{
    public class DBContext
    {
        public void SaveChanges()
        {
            //SetValue("Members", Members);
            //SetValue("Departments", Departments);
            SetValue("Context", this);
        }

        public static DBContext LoadDBContext()
        {
            DBContext context = null;
            string val = GetValue("Context");

            if (val != null)
            {
                context = JsonConvert.DeserializeObject<DBContext>(GetValue("Context"));
            }

            if (context == null)
            {
                throw new JsonException("Cannot get context");
            }

            return context;
        }

        public DBContext()
        {
            if (Members == null)
                Members = new List<Member>();
            if (Departments == null)
                Departments = new List<Department>();

        }

        public List<Member> Members { get; set; }
        public List<Department> Departments { get; set; }
    }

}
