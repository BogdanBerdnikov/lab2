namespace lab1
{
    internal class Address
    {
        public Address(string index, string country, string city, string street, string house, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public string Index { get; }
        public string Country { get; }
        public string City { get; }
        public string Street { get; }
        public string House { get; }
        public string Apartment { get; }

        public void ShowAddressInfo()
        {
            Console.WriteLine("Address info: ");
            Console.WriteLine("Index: {0}", Index);
            Console.WriteLine("Country: {0}", Country);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Street: {0}", Street);
            Console.WriteLine("House: {0}", House);
            Console.WriteLine("Apartment: {0}", Apartment);
        }
    }
}
