using System;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomParamConverter: IRoomParamConverter
    {
        public RoomDao RoomDao { get; set; }
    }
}
