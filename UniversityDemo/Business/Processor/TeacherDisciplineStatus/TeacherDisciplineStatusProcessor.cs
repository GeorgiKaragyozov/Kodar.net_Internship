using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDisciplineStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Processor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusProcessor: ITeacherDisciplineStatusProcessor
    {
        public TeacherDisciplineStatusDao Dao { get; set; }

        public TeacherDisciplineStatusParamConverter ParamConverter { get; set; }

        public TeacherDisciplineStatusResultConverter ResultConverter { get; set; }

        public TeacherDisciplineStatusResult Create(TeacherDisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<TeacherDisciplineStatusResult> Create(List<TeacherDisciplineStatusParam> param)
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

        public TeacherDisciplineStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<TeacherDisciplineStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, TeacherDisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<TeacherDisciplineStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
