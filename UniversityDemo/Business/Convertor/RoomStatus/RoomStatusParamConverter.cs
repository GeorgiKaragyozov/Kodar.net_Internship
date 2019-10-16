using System;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public class RoomStatusParamConverter: IRoomStatusParamConverter
    {
        public RoomStatusDao RoomStatusDao { get; set; }

        public UniversityDemo.RoomStatus Convert(RoomStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
