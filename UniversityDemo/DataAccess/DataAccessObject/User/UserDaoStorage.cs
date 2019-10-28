using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.User
{
    public class UserDaoStorage
    {
        public static List<UniversityDemo.User> Users = new List<UniversityDemo.User>();

        public static IDictionary<long, UniversityDemo.User> Dictionary =
            new Dictionary<long, UniversityDemo.User>();

        static UserDaoStorage()
        {
            UniversityDemo.User user1 = new UniversityDemo.User()
            {

            };

            UniversityDemo.User user2 = new UniversityDemo.User()
            {

            };

            UniversityDemo.User user3 = new UniversityDemo.User()
            {

            };

            Users.Add(user1);
            Users.Add(user2);
            Users.Add(user3);

            Dictionary.Add(user1.Id, user1);
            Dictionary.Add(user2.Id, user2);
            Dictionary.Add(user3.Id, user3);
        }
    }
}
