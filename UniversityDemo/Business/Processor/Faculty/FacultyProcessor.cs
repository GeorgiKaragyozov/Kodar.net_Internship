using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Faculty;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Processor.Faculty
{
    public class FacultyProcessor: IFacultyProcessor
    {
        public IFacultyDao Dao { get; set; }

        public IFacultyParamConverter ParamConverter { get; set; }

        public IFacultyResultConverter ResultConverter { get; set; }

        public FacultyProcessor(IFacultyDao dao, IFacultyParamConverter paramConverter,
            IFacultyResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public FacultyResult Create(FacultyParam param)
        {
            throw new NotImplementedException();
        }

        public List<FacultyResult> Create(List<FacultyParam> param)
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

        public FacultyResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<FacultyResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, FacultyParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<FacultyParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
