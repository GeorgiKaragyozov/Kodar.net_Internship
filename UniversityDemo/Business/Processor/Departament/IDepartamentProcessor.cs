using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Departament;

namespace UniversityDemo.Business.Processor.Departament
{
    public interface IDepartamentProcessor
    {
        DepartamentResult Create(DepartamentParam param);
        List<DepartamentResult> Create(List<DepartamentParam> param);

        void Update(long id, DepartamentParam param);
        void Update(List<DepartamentParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        DepartamentResult Find(long id);
        List<DepartamentResult> Find();
    }
}
