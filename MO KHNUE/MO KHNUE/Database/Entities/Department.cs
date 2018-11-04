using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE.Entities
{
    public class Department
    {
        public Department()
        {
            ID = Rand.RandGuid();
            Members = new List<Member>();
        }

        [Key]
        public Guid ID;
        public string Name;
        public string FullName;
        public Member Head;
        public Image Image;
        public List<Member> Members;

        public int MembersCount
        {
            get
            {
                int res = Members.Count;
                if (!Members.Contains(Head))
                    res++;
                return res;
            }
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
