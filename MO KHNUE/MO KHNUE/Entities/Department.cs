using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Member Head;
        public List<Member> Members;

        public override string ToString()
        {
            return Name;
        }
    }
}
