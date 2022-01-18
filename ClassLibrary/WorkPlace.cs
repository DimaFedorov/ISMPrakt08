using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class WorkPlace
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
    }
}
