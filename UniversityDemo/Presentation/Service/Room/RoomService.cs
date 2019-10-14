using System;
using UniversityDemo.Business.Processor.Room;

namespace UniversityDemo.Presentation.Service.Room
{
    public class RoomService: IRoomService
    {
        public RoomProcessor Processor { get; set; }
    }
}
