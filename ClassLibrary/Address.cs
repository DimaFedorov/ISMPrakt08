using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Address
    {
        protected string Country;
        protected string City;
        protected string Street;
        protected int HouseNumber;
        protected int Index;

        public Address(string country, string city, string street, int housenumber, int index)
        {
            Country = country;
            City = city;
            Street = street;
            HouseNumber = housenumber;
            Index = index;
        }

        public Address(Address address)
        {
            Country = address.Country;
            City = address.City;
            Street = address.Street;
            HouseNumber = address.HouseNumber;
            Index = address.Index;
        }
    }
}
