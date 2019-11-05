using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDemo.DataAccess.DataAccessObject.Room
{
    public class RoomDaoStorage
    {
        public static List<Model.Room> Rooms = new List<Model.Room>();

        public static IDictionary<long, Model.Room> Dictionary = new Dictionary<long, Model.Room>();

        static RoomDaoStorage()
        {
            Model.Room room1 = new Model.Room()
            {

            };

            Model.Room room2 = new Model.Room()
            {

            };

            Model.Room room3 = new Model.Room()
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
