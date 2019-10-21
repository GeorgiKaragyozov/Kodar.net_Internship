using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DisciplineStatus;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Processor.DisciplineStatus
{
    public class DisciplineStatusProcessor: IDisciplineStatusProcessor
    {
        public IDisciplineStatusDao Dao { get; set; }

        public IDisciplineStatusParamConverter ParamConverter { get; set; }

        public IDisciplineStatusResultConverter ResultConverter { get; set; }

        public DisciplineStatusProcessor(IDisciplineStatusDao dao, IDisciplineStatusParamConverter paramConverter,
            IDisciplineStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public DisciplineStatusResult Create(DisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<DisciplineStatusResult> Create(List<DisciplineStatusParam> param)
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

        public DisciplineStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<DisciplineStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, DisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<DisciplineStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
