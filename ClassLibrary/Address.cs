using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Address
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
        public string GetCountry()
        {
            return Country;
        }
        public string GetCity()
        {
            return City;
        }
        public string GetStreet()
        {
            return Street;
        }
        public int GetHouseNumber()
        {
            return HouseNumber;
        }
        public int GetIndex()
        {
            return Index;
        }
        public void SetCountry(string country)
        {
            Country = country;
        }
        public void SetCity(string city)
        {
            City = city;
        }
        public void SetStreet(string street)
        {
            Street = street;
        }
        public void SetHouseNumber(int housenumber)
        {
            HouseNumber = housenumber;
        }
        public void SetIndex(int index)
        {
            Index = index;
        }
    }
}
