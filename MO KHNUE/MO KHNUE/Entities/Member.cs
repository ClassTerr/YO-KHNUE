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
    [Table("Members")]
    public class Member : IEquatable<Member>
    {
        public Member()
        {
            ID = Rand.RandGuid();
        }

        [Key]
        public Guid ID;
        public string Name;
        public string Surname;
        public string Phone;
        public string Group;
        public int Course;
        public string Email;
        public DateTime BirthDay;
        public Image Photo;

        public string FullName
        {
            get { return Name + " " + Surname; }
        }


        public override string ToString()
        {
            return $"{{ {Name} {Surname} {Phone} {Group} {Course} {Email} {BirthDay.ToShortDateString()} }}";
        } 

        public bool Equals(Member other)
        {
            if (other is Member mem)
            {
                return mem.ID == ID;
            }
            else return false;
        }
    }
}
