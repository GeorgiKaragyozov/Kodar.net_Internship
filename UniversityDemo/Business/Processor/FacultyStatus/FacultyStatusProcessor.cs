using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.FacultyStatus;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Processor.FacultyStatus
{
    public class FacultyStatusProcessor: IFacultyStatusProcessor
    {
        public IFacultyStatusDao Dao { get; set; }

        public IFacultyStatusParamConverter ParamConverter { get; set; }

        public IFacultyStatusResultConverter ResultConverter { get; set; }

        public FacultyStatusProcessor(IFacultyStatusDao dao, IFacultyStatusParamConverter paramConverter,
            IFacultyStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public FacultyStatusResult Create(FacultyStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<FacultyStatusResult> Create(List<FacultyStatusParam> param)
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

        public FacultyStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<FacultyStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, FacultyStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<FacultyStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
