using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDiscipline;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Processor.TeacherDiscipline
{
    public class TeacherDisciplineProcessor: ITeacherDisciplineProcessor
    {
        public ITeacherDisciplineDao Dao { get; set; }

        public ITeacherDisciplineParamConverter ParamConverter { get; set; }

        public ITeacherDisciplineResultConverter ResultConverter { get; set; }

        public TeacherDisciplineProcessor(ITeacherDisciplineDao dao,
            ITeacherDisciplineParamConverter paramConverter,
            ITeacherDisciplineResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

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
