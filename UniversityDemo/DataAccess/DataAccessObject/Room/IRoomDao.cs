using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Room
{
    public interface IRoomDao
    {
        Model.Room Save(Model.Room entity);
        List<Model.Room> Save(List<Model.Room> entity);

        Model.Room Update(Model.Room entity);
        List<Model.Room> Update(List<Model.Room> entity);

        void Delete(long id);
        void Delete(Model.Room entity);
        void Delete(List<long> idList);

        List<Model.Room> Find();
        Model.Room Find(long id);
    }
}
