using System;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public class RoomStatusParamConverter: IRoomStatusParamConverter
    {
        public IRoomStatusDao Dao = new RoomStatusDao();

        //public RoomStatusParamConverter(IRoomStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.RoomStatus Convert(RoomStatusParam param)
        {
            UniversityDemo.RoomStatus entity = new UniversityDemo.RoomStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public UniversityDemo.RoomStatus Convert(RoomStatusParam param,
           UniversityDemo.RoomStatus oldEntity)
        {
            UniversityDemo.RoomStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.RoomStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
