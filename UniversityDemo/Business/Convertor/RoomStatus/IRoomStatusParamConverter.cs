namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public interface IRoomStatusParamConverter
    {
        Model.RoomStatus Convert(RoomStatusParam param, Model.RoomStatus oldEntity);
    }
}
