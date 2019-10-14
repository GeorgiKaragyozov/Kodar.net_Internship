using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Student
{
    public interface IStudentDao<T>
    {
        T Save(T entity);
        List<T> SaveList(List<T> entity);

        T Update(T entity);
        List<T> UpdateList(List<T> entity);

        void Delete(long id);
        void Delete(T entity);
        void Delete(List<long> idList);

        List<T> FindList();
        T Find(long id);
    }
}
