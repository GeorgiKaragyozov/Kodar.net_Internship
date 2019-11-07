using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public interface IRoomStatusResultConverter
    {
        RoomStatusResult Convert(Model.RoomStatus param);
    }
}
