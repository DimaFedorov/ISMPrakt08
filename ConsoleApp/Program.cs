using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            DateTime date1 = new DateTime(2020, 05, 13);
            Address address1 = new Address("Україна", "Житомир", "Лесі Українки", 23, 10000);
            WorkPlace workPlace1 = new WorkPlace("ISM", address1, "Програміст", 5, +380503130321, "krash.23@gmail.com");
            Employee employee1 = new Employee("Дмитро", "Федоров", "Анатолійович", "Вища", "Англійська,Російська", "Танці", date1, workPlace1);

            DateTime date2 = new DateTime(2021, 11, 25);
            Address address2 = new Address("Україна", "Житомир", "Велика Бердичівська", 3, 10000);
            WorkPlace workPlace2 = new WorkPlace("ISM", address1, "Тестувальник", 12, +380735040301, "lover23@gmail.com");
            Employee employee2 = new Employee("Данил", "Бойко", "Сергійович", "Середня", "Англійська,Російська,Польська", "Малювання", date1, workPlace1);

            Console.WriteLine($"ПІБ: {employee1.GetFirstName()} {employee1.GetLastName()} {employee1.GetSurname()}" +
                $"\nДата прийняття на роботу: { date1.ToString("dd-MM-yyyy")}" +
                $"\nОсвіта: {employee1.GetEducation()}" +
                $"\nМови: {employee1.GetLanguage()}" +
                $"\nНазва компанії: {workPlace1.GetNameCompany()}" +
                $"\nСпеціальність: {workPlace1.GetSpecialty()}" +
                $"\nДосвід: {workPlace1.GetExperience()} років" +
                $"\nАдреса: вулиця {address1.GetStreet()},{address1.GetHouseNumber()}, {address1.GetIndex()},{address1.GetCountry()}, {address1.GetCity()}");

            Console.WriteLine($"\nПІБ: {employee2.GetFirstName()} {employee2.GetLastName()} {employee2.GetSurname()}" +
               $"\nДата прийняття на роботу: { date2.ToString("dd-MM-yyyy")}" +
               $"\nОсвіта: {employee2.GetEducation()}" +
               $"\nМови: {employee2.GetLanguage()}" +
               $"\nНазва компанії: {workPlace2.GetNameCompany()}" +
               $"\nСпеціальність: {workPlace2.GetSpecialty()}" +
               $"\nДосвід: {workPlace2.GetExperience()} років" +
               $"\nАдреса: вулиця {address2.GetStreet()},{address2.GetHouseNumber()}, {address2.GetIndex()}, {address2.GetCountry()}, {address2.GetCity()}");

            Console.ReadKey();

        }
    }
}
