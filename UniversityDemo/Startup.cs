using System;
using UniversityDemo.Enums;
using UniversityDemo.Presentation;
using UniversityDemo.Presentation.Service.Account;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Account;
using UniversityDemo.Business.Processor.Account;

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

            Console.ReadKey();
        }
    }
}
