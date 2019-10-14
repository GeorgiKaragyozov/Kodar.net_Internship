using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public interface IRoomStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.RoomStatus param);
    }
}
