namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public interface IRoomStatusParamConverter
    {
        UniversityDemo.RoomStatus Convert(RoomStatusParam param);
        UniversityDemo.RoomStatus Convert(RoomStatusParam param,
           UniversityDemo.RoomStatus oldEntity);
    }
}
