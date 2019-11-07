using UniversityDemo.DataAccess.DataAccessObject.RoomStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.RoomStatus
{
    public class RoomStatusParamConverter: IRoomStatusParamConverter
    {
        IRoomStatusDao Dao = new RoomStatusDao();

        public Model.RoomStatus Convert(RoomStatusParam param, Model.RoomStatus oldEntity)
        {
            Model.RoomStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.RoomStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            return entity;
        }
    }
}
