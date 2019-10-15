using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomParamConverter: IRoomParamConverter
    {
        public RoomDao RoomDao { get; set; }

        public UniversityDemo.Room Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
