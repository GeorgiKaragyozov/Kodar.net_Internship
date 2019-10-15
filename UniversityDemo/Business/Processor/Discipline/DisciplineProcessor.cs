using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Discipline;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Processor.Discipline
{
    public class DisciplineProcessor: IDisciplineProcessor
    {
        public DisciplineDao DisciplineDao { get; set; }

        public DisciplineParamConverter DisciplineParamConverter { get; set; }

        public DisciplineResultConverter DisciplineResultConverter { get; set; }

        public DisciplineResult Create(DisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public List<DisciplineResult> Create(List<DisciplineParam> param)
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

        public DisciplineResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<DisciplineResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, DisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<DisciplineParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
