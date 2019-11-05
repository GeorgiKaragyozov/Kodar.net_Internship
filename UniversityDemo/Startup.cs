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
                Name = "Ivan name",
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
                Email = "Ivan@abv.bg",
                UserId = 51,
                StatusId = 5
            };

            AccountService service = new AccountService();

            Console.WriteLine("Create new Account :");
            Console.WriteLine(service.Create(param).Text);

            Console.WriteLine(new string('_', 80));

            Console.WriteLine("Listing all accounts :");
            Console.WriteLine(service.ListAll().Text);

            Console.WriteLine(new string('_', 80));

            Console.WriteLine("Find entity by PK :");
            Console.WriteLine(service.FindByPk(1).Text);

            Console.WriteLine(new string('_', 80));

            Console.WriteLine("Find entity by field :");
            Console.WriteLine(service.FindByField("FirstName", "Georgi").Text);

            Console.WriteLine(new string('_', 80));

            Console.ReadKey();
        }
    }
}
