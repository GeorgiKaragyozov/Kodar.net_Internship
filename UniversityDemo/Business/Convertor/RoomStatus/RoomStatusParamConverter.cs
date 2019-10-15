using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public class RoomStatusParamConverter: IRoomStatusParamConverter
    {
        public RoomStatusDao RoomStatusDao { get; set; }

        public UniversityDemo.RoomStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
