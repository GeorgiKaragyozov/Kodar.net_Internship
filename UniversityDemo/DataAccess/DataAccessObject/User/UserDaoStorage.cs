using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.User
{
    public class UserDaoStorage
    {
        public static List<Model.User> Users = new List<Model.User>();

        public static Dictionary<long, Model.User> Dictionary =
            new Dictionary<long, Model.User>();

        static UserDaoStorage()
        {
            Model.User user1 = new Model.User()
            {
                Id = 11,
                Password = "11",
                Username = "Ivan"
            };

            Model.User user2 = new Model.User()
            {
                Id = 21,
                Password = "21",
                Username = "Georgi"
            };

            Model.User user3 = new Model.User()
            {
                Id = 31,
                Password = "31",
                Username = "Dimitur"
            };

            Model.User user4 = new Model.User()
            {
                Id = 41,
                Password = "41",
                Username = "Mario"
            };

            Model.User user5 = new Model.User()
            {
                Id = 51,
                Password = "51",
                Username = "Ivan new"
            };

            Users.Add(user1);
            Users.Add(user2);
            Users.Add(user3);
            Users.Add(user4);
            Users.Add(user5);

            Dictionary.Add(user1.Id, user1);
            Dictionary.Add(user2.Id, user2);
            Dictionary.Add(user3.Id, user3);
            Dictionary.Add(user4.Id, user4);
            Dictionary.Add(user5.Id, user5);
        }
    }
}
