using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.RoomStatus
{
    public interface IRoomStatusDao
    {
        Model.RoomStatus Save(Model.RoomStatus entity);
        List<Model.RoomStatus> Save(List<Model.RoomStatus> entity);

        Model.RoomStatus Update(Model.RoomStatus entity);
        List<Model.RoomStatus> Update(List<Model.RoomStatus> entity);

        void Delete(long id);
        void Delete(Model.RoomStatus entity);
        void Delete(List<long> idList);

        List<Model.RoomStatus> Find();
        Model.RoomStatus Find(long id);
    }
}
