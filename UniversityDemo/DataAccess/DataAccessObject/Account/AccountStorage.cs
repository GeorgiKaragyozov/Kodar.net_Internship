using System;
using System.Collections.Generic;
using UniversityDemo.Enums;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public class AccountStorage
    {
        public static List<UniversityDemo.Account> Accounts = new List<UniversityDemo.Account>();

        public IDictionary<long, UniversityDemo.Account> AccountDictionary = new Dictionary<long, UniversityDemo.Account>();

        static AccountStorage()
        {
            UniversityDemo.Account account1 = new UniversityDemo.Account()
            {
                Id = 1,
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

            UniversityDemo.Account account2 = new UniversityDemo.Account()
            {
                Id = 2,
                Description = "Student account",
                FirstName = "Georgi",
                MiddleName = "Ivanov",
                LastName = "Marinov",
                Egn = "1234567890",
                Address = "kichuka",
                City = "Plovdiv",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976654220",
                GenderType = Gender.Male,
                Email = "Georgi@abv.bg"
            };

            UniversityDemo.Account account3 = new UniversityDemo.Account()
            {
                Id = 3,
                Description = "Teacher account",
                FirstName = "Mitko",
                MiddleName = "Ivan",
                LastName = "Petrov",
                Egn = "1234567890",
                Address = "kichuka",
                City = "Plovdiv",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976652130",
                GenderType = Gender.Male,
                Email = "Mitko@abv.bg"
            };

            UniversityDemo.Account account4 = new UniversityDemo.Account()
            {
                Id = 4,
                Description = "Teacher account",
                FirstName = "Veso",
                MiddleName = "Georgiev",
                LastName = "Kuzmanov",
                Egn = "1234567890",
                Address = "kichuka",
                City = "Plovdiv",
                Country = "Bulgaria",
                HomePhone = "032221144",
                MobilePhone = "08976654220",
                GenderType = Gender.Male,
                Email = "Veso@abv.bg"
            };

            Accounts.Add(account1);
            Accounts.Add(account2);
            Accounts.Add(account3);
            Accounts.Add(account4);

            //AccountDictionary = Accounts.ForEach(n => n.);
        }       
    }
}
