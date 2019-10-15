using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Room
{
    public interface IRoomDao
    {
        UniversityDemo.Room Save(UniversityDemo.Room entity);
        List<UniversityDemo.Room> Save(List<UniversityDemo.Room> entity);

        UniversityDemo.Room Update(UniversityDemo.Room entity);
        List<UniversityDemo.Room> Update(List<UniversityDemo.Room> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Room entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Room> Find();
        UniversityDemo.Room Find(long id);
    }
}
