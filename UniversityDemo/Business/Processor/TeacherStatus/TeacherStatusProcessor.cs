using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Processor.TeacherStatus
{
    public class TeacherStatusProcessor: ITeacherStatusProcessor
    {
        public ITeacherStatusDao Dao { get; set; }

        public ITeacherStatusParamConverter ParamConverter { get; set; }

        public ITeacherStatusResultConverter ResultConverter { get; set; }

        public TeacherStatusProcessor(ITeacherStatusDao dao, 
            ITeacherStatusParamConverter paramConverter,
            ITeacherStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public TeacherStatusResult Create(TeacherStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<TeacherStatusResult> Create(List<TeacherStatusParam> param)
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

        public TeacherStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<TeacherStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, TeacherStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<TeacherStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
