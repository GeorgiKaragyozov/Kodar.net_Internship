using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDemo.Enums;

namespace UniversityDemo.DataAccess.DataAccessObject.Teacher
{
    public class TeacherDaoStorage
    {
        public static List<Model.Teacher> Teachers = new List<Model.Teacher>();

        public static IDictionary<long, Model.Teacher> Dictionary =
            new Dictionary<long, Model.Teacher>();

        static TeacherDaoStorage()
        {
            Model.Teacher teacher1 = new Model.Teacher()
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

            Model.Teacher teacher2 = new Model.Teacher()
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

            Model.Teacher teacher3 = new Model.Teacher()
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

            Teachers.Add(teacher1);
            Teachers.Add(teacher2);
            Teachers.Add(teacher3);

            Dictionary.Add(teacher1.Id, teacher1);
            Dictionary.Add(teacher2.Id, teacher2);
            Dictionary.Add(teacher3.Id, teacher3);
        }
    }
}
