using MO_KHNUE.Controllers;
using Newtonsoft.Json;
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
    public class Member : IEquatable<Member>, ISearchable
    {
        public Member()
        {
            ID = Rand.RandGuid();
            BirthDay = DateTime.Now;
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
        public string PhotoString;
        [JsonIgnore]
        private Image photo = null;
        [JsonIgnore]
        public Image Photo
        {
            get
            {
                if (photo == null && !String.IsNullOrEmpty(PhotoString))
                {
                    return photo = Utils.StringToImage(PhotoString);
                }

                return photo;
            }
            set
            {
                PhotoString = Utils.ImageToString(value);
                photo = value;
            }
        }
        [JsonIgnore]
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

        public bool IsMatches(string pattern)
        {
            pattern = pattern.Trim().ToLower();

            return Name.ToLower().Contains(pattern) ||
                Surname.ToLower().Contains(pattern) ||
                Group.ToLower().Contains(pattern) ||
                Email.ToLower().Contains(pattern) ||
                BirthDay.ToShortDateString().Contains(pattern);
        }
    }
}
