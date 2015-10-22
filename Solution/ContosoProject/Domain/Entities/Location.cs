namespace Domain.Entities
{
    public class Location
    {
        public string City { get; set; }
        public string Address { get; set; }

        public Location()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} city {1}", City, Address);
        }
    }

}
