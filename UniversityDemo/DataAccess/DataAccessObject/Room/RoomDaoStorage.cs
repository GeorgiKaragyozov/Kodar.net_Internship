using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Room
{
    public class RoomDaoStorage
    {
        public static List<UniversityDemo.Room> Rooms = new List<UniversityDemo.Room>();

        public static IDictionary<long, UniversityDemo.Room> Dictionary = new Dictionary<long, UniversityDemo.Room>();

        static RoomDaoStorage()
        {
            UniversityDemo.Room room1 = new UniversityDemo.Room()
            {

            };

            UniversityDemo.Room room2 = new UniversityDemo.Room()
            {

            };

            UniversityDemo.Room room3 = new UniversityDemo.Room()
            {

            };

            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);

            Dictionary.Add(room1.Id, room1);
            Dictionary.Add(room2.Id, room2);
            Dictionary.Add(room3.Id, room3);
        }
    }
}
