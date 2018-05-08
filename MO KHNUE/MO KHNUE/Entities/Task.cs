using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE.Entities
{
    public class Task
    {
        [Key]
        public int ID;
        public int EventID { get; set; }
        public Member Member { get; set; }
        public double Order { get; set; }
        public int Priority { get; set; }
        public DateTime Deadline { get; set; }
        public bool Done { get; set; }

        public override string ToString()
        {
            return $"{{ {EventID} {Member.ToString()} {Order} {Priority} {Deadline} }}";
        }
    }
}
