using System;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Processor.Room
{
    public class RoomProcessor: IRoomProcessor
    {
        public RoomDao RoomDao { get; set; }
    }
}
