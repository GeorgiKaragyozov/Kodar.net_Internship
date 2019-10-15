using System;
using Newtonsoft.Json;
using UniversityDemo.Enums;
using UniversityDemo.Presentation.Serialization;
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
            Account student = new Account()
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

            //Serialization<Student> serialization = new Serialization<Student>();

            //string json = serialization.Serizlize(student);

            //Console.WriteLine(json);

            ////Student obj = serialization.Deserialize(json);

            ////Console.WriteLine(obj.FirstName);

            string converted = JsonConvert.SerializeObject(student);

            AccountParamConverter converterParam = new AccountParamConverter();
            AccountResultConverter converterResult = new AccountResultConverter();
            AccountDao dao = new AccountDao();
            AccountProcessor proccesor = new AccountProcessor() { AccountDao = dao, AccountParamConverter = converterParam, AccountResultConverter = converterResult };
            AccountService service = new AccountService() { Processor = proccesor };

            AccountParam param = new AccountParam() { Input = converted };

            Console.WriteLine(service.Create(param).Text);

            Console.ReadKey();
        }
    }
}
