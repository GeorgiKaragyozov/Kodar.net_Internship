using System;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomParamConverter: IRoomParamConverter
    {
        public IRoomDao Dao { get; set; }

        public RoomParamConverter(IRoomDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Room Convert(RoomParam param)
        {
            throw new NotImplementedException();
        }
    }
}
