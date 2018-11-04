using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE.Entities
{
    public class TaskDescription
    {
        [Key]
        public int ID;
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
