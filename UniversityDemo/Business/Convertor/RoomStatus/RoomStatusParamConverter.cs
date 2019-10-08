using System;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public class RoomStatusParamConverter: IRoomStatusParamConverter
    {
        public RoomStatusDao RoomStatusDao { get; set; }
    }
}
