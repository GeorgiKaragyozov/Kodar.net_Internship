using System.Collections.Generic;
using UniversityDemo.Enums;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public class AccountStorage
    {
        public static List<UniversityDemo.Account> Accounts = new List<UniversityDemo.Account>();

        public static IDictionary<long, UniversityDemo.Account> Dictionary 
            = new Dictionary<long, UniversityDemo.Account>();

        static AccountStorage()
        {
            UniversityDemo.Account account1 = new UniversityDemo.Account()
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

            UniversityDemo.Account account2 = new UniversityDemo.Account()
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

            UniversityDemo.Account account3 = new UniversityDemo.Account()
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

            UniversityDemo.Account account4 = new UniversityDemo.Account()
            {
                Id = 4,
                Name = "The name is Mario",
                Code = "Mario code",
                Description = "Teacher Mario Georgiev Kuzmanov",
                FirstName = "Mario",
                MiddleName = "Georgiev",
                LastName = "Kuzmanov",
                Egn = "79836126312",
                Address = "Marasha",
                City = "Plovdiv",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976654220",
                GenderType = Gender.Male,
                Email = "MarioKuzmanov@gmail.com"
            };

            Accounts.Add(account1);
            Accounts.Add(account2);
            Accounts.Add(account3);
            Accounts.Add(account4);

            Dictionary.Add(account1.Id, account1);
            Dictionary.Add(account2.Id, account2);
            Dictionary.Add(account3.Id, account3);
            Dictionary.Add(account4.Id, account4);
        }       
    }
}
