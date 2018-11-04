namespace MO_KHNUE.Entities
{
    public class Place
    {
        public int ID;
        public string Address { get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
