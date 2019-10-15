using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Departament;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Processor.Departament
{
    public class DepartamentProcessor: IDepartamentProcessor
    {
        public DepartamentDao DepartamentDao { get; set; }

        public DepartamentParamConverter DepartamentParamConverter { get; set; }

        public DepartamentResultConverter DepartamentResultConverter { get; set; }

        public DepartamentResult Create(DepartamentParam param)
        {
            throw new NotImplementedException();
        }

        public List<DepartamentResult> Create(List<DepartamentParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public DepartamentResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<DepartamentResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, DepartamentParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<DepartamentParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
