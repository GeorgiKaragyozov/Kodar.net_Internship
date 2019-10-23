using System;
using UniversityDemo.Enums;
using UniversityDemo.Presentation;
using UniversityDemo.Presentation.Service.Account;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Account;
using UniversityDemo.Business.Processor.Account;
using System.Collections.Generic;
using UniversityDemo.Data.Common;

namespace UniversityDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
            AccountParam param = new AccountParam()
            {
                Id = 1,
                Code = 1,
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
            Console.WriteLine("Adding an Account");

            ApiResponse response = service.Create(param);

            Console.WriteLine(response.Text);

            ApiResponse findByName = service.FindByName("Ivan");

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Listing all accounts");

            //ApiResponse listAll = service.ListAll();

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Removing an account");

            ApiResponse deleteEntity = service.DeleteById(1);
            //ApiResponse findName = service.FindByName(param.FullName);

            Console.WriteLine(deleteEntity.Text);

            Console.ReadKey();
        }
    }
}
