namespace UniversityDemo.Business.Convertor.Room
{
    public interface IRoomParamConverter
    {
        UniversityDemo.Room Convert(RoomParam param);

        UniversityDemo.Room Convert(RoomParam param, UniversityDemo.Room oldEntity);
    }
}
