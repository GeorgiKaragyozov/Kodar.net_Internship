using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.RoomStatus
{
    public class RoomStatusDaoStorage
    {
        public static List<UniversityDemo.RoomStatus> Rooms = new List<UniversityDemo.RoomStatus>();

        public static IDictionary<long, UniversityDemo.RoomStatus> Dictionary = 
            new Dictionary<long, UniversityDemo.RoomStatus>();

        static RoomStatusDaoStorage()
        {
            UniversityDemo.RoomStatus room1 = new UniversityDemo.RoomStatus()
            {

            };

            UniversityDemo.RoomStatus room2 = new UniversityDemo.RoomStatus()
            {

            };

            UniversityDemo.RoomStatus room3 = new UniversityDemo.RoomStatus()
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
