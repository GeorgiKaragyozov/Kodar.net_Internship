using System;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomResultConverter : IRoomResultConverter
    {
        public RoomResult Convert(UniversityDemo.Room param)
        {
            RoomResult result = new RoomResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status
            };

            return result;
        }
    }
}
