using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Student;
using UniversityDemo.DataAccess.DataAccessObject.Student;

namespace UniversityDemo.Business.Processor.Student
{
    public class StudentProcessor : IStudentProcessor
    {
        public IStudentDao Dao { get; set; }

        public IStudentParamConverter ParamConverter { get; set; }

        public IStudentResultConverter ResultConverter { get; set; }

        public StudentProcessor(IStudentDao dao, IStudentParamConverter paramConverter,
            IStudentResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public StudentResult Create(StudentParam param)
        {
            throw new NotImplementedException();
        }

        public List<StudentResult> Create(List<StudentParam> param)
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

        public StudentResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<StudentResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, StudentParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<StudentParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
