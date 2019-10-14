using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public interface IRoomStatusParamConverter
    {
        UniversityDemo.RoomStatus Convert(AccountParam param);
    }
}
