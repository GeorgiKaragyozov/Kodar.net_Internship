using System;
using UniversityDemo.DataAccess.DataAccessObject.Room;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomParamConverter: IRoomParamConverter
    {
        public IRoomDao Dao = new RoomDao();

        //public RoomParamConverter(IRoomDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.Room Convert(RoomParam param)
        {
            UniversityDemo.Room entity = new UniversityDemo.Room()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status
            };

            return entity;
        }

        public UniversityDemo.Room Convert(RoomParam param,
            UniversityDemo.Room oldEntity)
        {
            UniversityDemo.Room entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.Room();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Status = param.Status;

            return entity;
        }
    }
}
