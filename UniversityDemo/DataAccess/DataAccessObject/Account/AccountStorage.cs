using System.Collections.Generic;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;
using UniversityDemo.DataAccess.DataAccessObject.User;
using UniversityDemo.Enums;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public class AccountStorage
    {
        public static IAccountStatusDao StatusDao = new AccountStatusDao();

        public static IUserDao UserDao = new UserDao();

        public static List<Model.Account> Accounts = new List<Model.Account>();

        public static Dictionary<long, Model.Account> Dictionary 
            = new Dictionary<long, Model.Account>();

        static AccountStorage()
        {
            Model.Account account1 = new Model.Account()
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
                Email = "IvanMarinov@gmail.com",
                Status = StatusDao.Find(1),
                User = UserDao.Find(11)
            };

            Model.Account account2 = new Model.Account()
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
                Email = "GeorgiIvanov@gmail.com",
                Status = StatusDao.Find(2),
                User = UserDao.Find(21)
            };

            Model.Account account3 = new Model.Account()
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
                Email = "DimiturPetrov@gmail.com",
                Status = StatusDao.Find(3),
                User = UserDao.Find(31)
            };

            Model.Account account4 = new Model.Account()
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
                Email = "MarioKuzmanov@gmail.com",
                Status = StatusDao.Find(4),
                User = UserDao.Find(41)
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
