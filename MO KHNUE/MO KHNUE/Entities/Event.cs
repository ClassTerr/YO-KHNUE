using System;
using System.ComponentModel.DataAnnotations;

namespace MO_KHNUE.Entities
{
    public class Event
    {
        [Key]
        public int ID;
        public string EventName;
        public Department OrganizerDepartment;
        public DateTime Start;
        public DateTime End;
        public Place Place;
        public Member ResponsibleMember;

        public override string ToString()
        {
            return EventName;
        }
    }
}
