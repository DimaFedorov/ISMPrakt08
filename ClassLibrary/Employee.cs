using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        protected string FirstName;
        protected string LastName;
        protected string Surname;
        protected string Education;
        protected string Language;
        protected string Hobby;
        protected DateTime Date;
        protected WorkPlace WorkPlace;
        public Employee(string firstname, string lastname, string surname, string education, string language, string hobby, DateTime date, WorkPlace workplace)
        {
            FirstName = firstname;
            LastName = lastname;
            Surname = surname;
            Education = education;
            Language = language;
            Hobby = hobby;
            WorkPlace = new WorkPlace(workplace);
        }
        public Employee(Employee employee)
        {
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Surname = employee.Surname;
            Education = employee.Education;
            Language = employee.Language;
            Hobby = employee.Hobby;
            DateTime toBeClonedDateTime = DateTime.Now;
            DateTime cloned = toBeClonedDateTime;
            WorkPlace = new WorkPlace(employee.WorkPlace);
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public string GetEducation()
        {
            return Education;
        }
        public string GetLanguage()
        {
            return Language;
        }
        public string GetHobby()
        {
            return Hobby;
        }
        public WorkPlace GetWorkPlace()
        {
            return WorkPlace;
        }
        public void SetFirstName(string firstname)
        {
            FirstName = firstname;
        }
        public void SetLastName(string lastname)
        {
            LastName = lastname;
        }
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetWorkPlace(WorkPlace workPlace)
        {
            WorkPlace = workPlace;
        }
        public void SetEducation(string education)
        {
            Education = education;
        }
        public void SetLanguage(string language)
        {
            Language = language;
        }
        public void SetHobby(string hobby)
        {
            Hobby = hobby;
        }
    }
}
