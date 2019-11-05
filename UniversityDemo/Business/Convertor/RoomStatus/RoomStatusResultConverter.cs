namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public class RoomStatusResultConverter : IRoomStatusResultConverter
    {
        public RoomStatusResult Convert(Model.RoomStatus param)
        {
            RoomStatusResult result = new RoomStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return result;
        }
    }
}
