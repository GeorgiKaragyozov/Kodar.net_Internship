using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDemo.Enums;

namespace UniversityDemo.DataAccess.DataAccessObject.Student
{
    public class StudentDaoStorage
    {
        public static List<UniversityDemo.Student> Students = new List<UniversityDemo.Student>();

        public static IDictionary<long, UniversityDemo.Student> Dictionary =
            new Dictionary<long, UniversityDemo.Student>();

        static StudentDaoStorage()
        {
            UniversityDemo.Student student1 = new UniversityDemo.Student()
            {
                Id = 1,
                Name = "The name is Ivan",
                Code = "Ivan Code",
                Description = "Teacher Ivan Georgiev Marinov",
                FirstName = "Ivan",
                MiddleName = "Georgiev",
                LastName = "Marinov",
                Egn = "8388371213",
                Address = "kichuka",
                City = "Sofia",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976654220",
                GenderType = Gender.Male,
                Email = "IvanMarinov@gmail.com"
            };

            UniversityDemo.Student student2 = new UniversityDemo.Student()
            {
                Id = 2,
                Name = "The name is Georgi",
                Code = "Georgi Code",
                Description = "Student Georgi Ivanov Ivanov",
                FirstName = "Georgi",
                MiddleName = "Ivanov",
                LastName = "Ivanov",
                Egn = "3421367890",
                Address = "Centara",
                City = "Plovdiv",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976654220",
                GenderType = Gender.Male,
                Email = "GeorgiIvanov@gmail.com"
            };

            UniversityDemo.Student student3 = new UniversityDemo.Student()
            {
                Id = 3,
                Name = "The name is Dimitur",
                Code = "Dimitur code",
                Description = "Teacher Dimitur Ivanov Petrov",
                FirstName = "Dimitur",
                MiddleName = "Ivanov",
                LastName = "Petrov",
                Egn = "9934567890",
                Address = "Trakia",
                City = "Plovdiv",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976652130",
                GenderType = Gender.Male,
                Email = "DimiturPetrov@gmail.com"
            };

            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);

            Dictionary.Add(student1.Id, student1);
            Dictionary.Add(student2.Id, student2);
            Dictionary.Add(student3.Id, student3);
        }
    }
}
