using System;
using UniversityDemo.Enums;
using Newtonsoft.Json;
using UniversityDemo.Presentation.Serialization;
using UniversityDemo.Presentation.Service.Account;

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
                Egn = "1234567890"
            };

            Serialization<Student> serialization = new Serialization<Student>();

            string json = serialization.Serizlize(student);

            Console.WriteLine(json);

            //Student obj = serialization.Desialize(json);

            //Console.WriteLine(obj.FirstName);

            Console.ReadKey();
        }
    }
}
