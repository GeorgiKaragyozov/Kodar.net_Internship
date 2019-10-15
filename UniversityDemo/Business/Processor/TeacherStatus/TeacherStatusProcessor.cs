using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Processor.TeacherStatus
{
    public class TeacherStatusProcessor: ITeacherStatusProcessor
    {
        public TeacherStatusDao TeacherDao { get; set; }

        public TeacherStatusParamConverter TeacherParamConverter { get; set; }

        public TeacherStatusResultConverter TeacherResultConverter { get; set; }

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
