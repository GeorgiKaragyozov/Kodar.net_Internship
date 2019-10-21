using System;
using UniversityDemo.Enums;
using UniversityDemo.Presentation;
using UniversityDemo.Presentation.Service.Account;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Account;
using UniversityDemo.Business.Processor.Account;
using System.Collections.Generic;

namespace UniversityDemo
{
    class Startup
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
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

            string json = Serialization.Serizlize(student);
            Console.WriteLine(json);

            Console.WriteLine(Serialization.Deserialize(json));

            Console.WriteLine("------------------------------------------------------------------");

            AccountParam account = new AccountParam()
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

            IAccountDao dao = new AccountDao();
            IAccountParamConverter param = new AccountParamConverter(dao);
            IAccountResultConverter result = new AccountResultConverter();

            IAccountProcessor processor = new AccountProcessor(dao, param, result);

            IAccountService service = new AccountService(processor);
            service.Create(account);

            Console.ReadKey();
        }
    }
}
