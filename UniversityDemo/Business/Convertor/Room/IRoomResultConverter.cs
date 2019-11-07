using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Room
{
    public interface IRoomResultConverter
    {
        RoomResult Convert(Model.Room param);
    }
}
