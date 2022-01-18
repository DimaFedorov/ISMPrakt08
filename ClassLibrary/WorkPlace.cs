using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WorkPlace
    {
        protected string NameCompany;
        protected Address Address;
        protected string Specialty;
        protected int Experience;
        protected long PhoneNumber;
        protected string Email;

        public WorkPlace(string namecompany, Address address, string specialty, int experience, long phonenumber, string email)
        {
            NameCompany = namecompany;
            Address = new Address(address);
            Specialty = specialty;
            Experience = experience;
            PhoneNumber = phonenumber;
            Email = email;
        }

        public WorkPlace(WorkPlace workPlace)
        {
            NameCompany = workPlace.NameCompany;
            Address = new Address(workPlace.Address);
            Specialty = workPlace.Specialty;
            Experience = workPlace.Experience;
        }
        public string GetNameCompany()
        {
            return NameCompany;
        }
        public Address GetAddress()
        {
            return Address;
        }
        public string GetSpecialty()
        {
            return Specialty;
        }
        public int GetExperience()
        {
            return Experience;
        }
        public long GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetNameCompany(string namecompany)
        {
            NameCompany = namecompany;
        }
        public void SetAddress(Address address)
        {
            Address = address;
        }
        public void SetSpecialty(string specialty)
        {
            Specialty = specialty;
        }
        public void SetExperience(int experience)
        {
            Experience = experience;
        }
        public void SetPhoneNumber(long phonenumber)
        {
            PhoneNumber = phonenumber;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
