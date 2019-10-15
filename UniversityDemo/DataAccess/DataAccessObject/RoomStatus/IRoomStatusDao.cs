using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.RoomStatus
{
    public interface IRoomStatusDao
    {
        UniversityDemo.RoomStatus Save(UniversityDemo.RoomStatus entity);
        List<UniversityDemo.RoomStatus> Save(List<UniversityDemo.RoomStatus> entity);

        UniversityDemo.RoomStatus Update(UniversityDemo.RoomStatus entity);
        List<UniversityDemo.RoomStatus> Update(List<UniversityDemo.RoomStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.RoomStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.RoomStatus> Find();
        UniversityDemo.RoomStatus Find(long id);
    }
}
