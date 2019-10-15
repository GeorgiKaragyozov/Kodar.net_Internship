using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDiscipline;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Processor.TeacherDiscipline
{
    public class TeacherDisciplineProcessor: ITeacherDisciplineProcessor
    {
        public TeacherDisciplineDao TeacherDisciplineStatusDao { get; set; }

        public TeacherDisciplineParamConverter TeacherDisciplineParamConverter { get; set; }

        public TeacherDisciplineResultConverter TeacherDisciplineResultConverter { get; set; }

        public TeacherDisciplineResult Create(TeacherDisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public List<TeacherDisciplineResult> Create(List<TeacherDisciplineParam> param)
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

        public TeacherDisciplineResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<TeacherDisciplineResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, TeacherDisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<TeacherDisciplineParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
