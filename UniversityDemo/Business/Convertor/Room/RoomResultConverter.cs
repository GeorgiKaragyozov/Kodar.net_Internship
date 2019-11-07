using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomResultConverter : IRoomResultConverter
    {
        public RoomResult Convert(Model.Room param)
        {
            RoomResult result = new RoomResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                
                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };

            return result;
        }
    }
}
