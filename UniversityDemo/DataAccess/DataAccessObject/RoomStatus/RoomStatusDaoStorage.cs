using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.RoomStatus
{
    public class RoomStatusDaoStorage
    {
        public static List<Model.RoomStatus> Rooms = new List<Model.RoomStatus>();

        public static IDictionary<long, Model.RoomStatus> Dictionary = 
            new Dictionary<long, Model.RoomStatus>();

        static RoomStatusDaoStorage()
        {
            Model.RoomStatus room1 = new Model.RoomStatus()
            {

            };

            Model.RoomStatus room2 = new Model.RoomStatus()
            {

            };

            Model.RoomStatus room3 = new Model.RoomStatus()
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
