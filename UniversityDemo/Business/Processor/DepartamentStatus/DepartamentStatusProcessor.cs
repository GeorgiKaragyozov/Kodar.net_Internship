using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DepartamentStatus;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Processor.DepartamentStatus
{
    public class DepartamentStatusProcessor: IDepartamentStatusProcessor
    {
        public IDepartamentStatusDao Dao { get; set; }

        public IDepartamentStatusParamConverter ParamConverter { get; set; }

        public IDepartamentStatusResultConverter ResultConverter { get; set; }

        public DepartamentStatusProcessor(IDepartamentStatusDao dao, IDepartamentStatusParamConverter paramConverter,
            IDepartamentStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public DepartamentStatusResult Create(DepartamentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<DepartamentStatusResult> Create(List<DepartamentStatusParam> param)
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

        public DepartamentStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<DepartamentStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, DepartamentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<DepartamentStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
