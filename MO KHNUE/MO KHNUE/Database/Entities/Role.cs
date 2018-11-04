using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE.Entities
{
    public class Role
    {
        [Key]
        public int ID;
        public string Address { get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
