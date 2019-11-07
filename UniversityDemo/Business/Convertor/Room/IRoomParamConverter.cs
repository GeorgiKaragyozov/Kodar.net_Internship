using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Room
{
    public interface IRoomParamConverter
    {
        Model.Room Convert(RoomParam param, Model.Room oldEntity);
    }
}
