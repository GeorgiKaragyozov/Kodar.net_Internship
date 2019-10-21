using System;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public class RoomStatusParamConverter: IRoomStatusParamConverter
    {
        public IRoomStatusDao Dao { get; set; }

        public RoomStatusParamConverter(IRoomStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.RoomStatus Convert(RoomStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
