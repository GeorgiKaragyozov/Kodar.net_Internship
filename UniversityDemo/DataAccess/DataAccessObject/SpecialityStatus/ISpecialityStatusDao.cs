using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus
{
    public interface ISpecialityStatusDao
    {
        Model.SpecialityStatus Save(Model.SpecialityStatus entity);
        List<Model.SpecialityStatus> Save(List<Model.SpecialityStatus> entity);

        Model.SpecialityStatus Update(Model.SpecialityStatus entity);
        List<Model.SpecialityStatus> Update(List<Model.SpecialityStatus> entity);

        void Delete(long id);
        void Delete(Model.SpecialityStatus entity);
        void Delete(List<long> idList);

        List<Model.SpecialityStatus> Find();
        Model.SpecialityStatus Find(long id);
    }
}
