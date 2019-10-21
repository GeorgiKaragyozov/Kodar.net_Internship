using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Teacher;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;

namespace UniversityDemo.Business.Processor.Teacher
{
    public class TeacherProcessor: ITeacherProcessor
    {
        public ITeacherDao Dao { get; set; }

        public ITeacherParamConverter ParamConverter { get; set; }

        public ITeacherResultConverter ResultConverter { get; set; }

        public TeacherProcessor(ITeacherDao dao, ITeacherParamConverter paramConverter,
            ITeacherResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public TeacherResult Create(TeacherParam param)
        {
            throw new NotImplementedException();
        }

        public List<TeacherResult> Create(List<TeacherParam> param)
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

        public TeacherResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<TeacherResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, TeacherParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<TeacherParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
