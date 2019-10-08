using System;
using UniversityDemo.Business.Convertor.RoomStatus;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Processor.RoomStatus
{
    public class RoomStatusProcessor: IRoomStatusProcessor
    {
        public RoomStatusDao RoomStatusDao { get; set; }

        public RoomStatusParamConverter RoomStatusParamConverter { get; set; }

        public RoomStatusResultConverter RoomStatusResultConverter { get; set; }
    }
}
