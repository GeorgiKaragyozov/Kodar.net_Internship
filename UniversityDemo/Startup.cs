using System;
using UniversityDemo.Enums;
using UniversityDemo.Presentation.Service.Account;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
            AccountParam param = new AccountParam()
            {
                Id = 5,
                Code = "ivan code",
                Description = "Teacher account",
                FirstName = "Ivan",
                MiddleName = "Georgiev",
                LastName = "Marinov",
                Egn = "1234567890",
                Address = "kichuka",
                City = "Plovdiv",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976654220",
                GenderType = Gender.Male,
                Email = "Ivan@abv.bg"
            };

            AccountService service = new AccountService();

            Console.WriteLine(service.Create(param).Text);

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Listing all accounts");

            Console.WriteLine(service.ListAll().Text);

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Removing an account");

            Console.WriteLine(service.DeleteById(1).Text);

            Console.WriteLine(service.FindByPk(1).Text);

            Console.WriteLine(service.FindByName("The name is Georgi").Text);

            Console.WriteLine("Find by Code .");
            Console.WriteLine(service.FindByCode("Georgi code").Text);

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Find by description");
            Console.WriteLine(service.FindByDescription("Student Georgi Ivanov Ivanov").Text);

            Console.ReadKey();
        }
    }
}
