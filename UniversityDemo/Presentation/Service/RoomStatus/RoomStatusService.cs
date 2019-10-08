using System;
using UniversityDemo.Business.Processor.RoomStatus;

namespace UniversityDemo.Presentation.Service.RoomStatus
{
    public class RoomStatusService: IRoomStatusService
    {
        public RoomStatusProcessor RoomStatusProcessor { get; set; }
    }
}
