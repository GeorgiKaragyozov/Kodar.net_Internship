using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Speciality
{
    public interface ISpecialityDao
    {
        Model.Speciality Save(Model.Speciality entity);
        List<Model.Speciality> Save(List<Model.Speciality> entity);

        Model.Speciality Update(Model.Speciality entity);
        List<Model.Speciality> Update(List<Model.Speciality> entity);

        void Delete(long id);
        void Delete(Model.Speciality entity);
        void Delete(List<long> idList);

        List<Model.Speciality> Find();
        Model.Speciality Find(long id);
    }
}
