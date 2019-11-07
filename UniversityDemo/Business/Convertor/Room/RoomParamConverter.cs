using UniversityDemo.DataAccess.DataAccessObject.Room;
using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Room
{
    public class RoomParamConverter: IRoomParamConverter
    {
        IRoomDao Dao = new RoomDao();

        IRoomStatusDao StatusDao = new RoomStatusDao();

        public Model.Room Convert(RoomParam param, Model.Room oldEntity)
        {
            Model.Room entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Room
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
