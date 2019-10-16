using System;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomParamConverter: IRoomParamConverter
    {
        public RoomDao Dao { get; set; }

        public UniversityDemo.Room Convert(RoomParam param)
        {
            throw new NotImplementedException();
        }
    }
}
