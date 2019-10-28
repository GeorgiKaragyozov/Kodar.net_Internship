using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusParamConverter: ITeacherDisciplineStatusParamConverter
    {
        public ITeacherDisciplineStatusDao Dao = new TeacherDisciplineStatusDao();

        //public TeacherDisciplineStatusParamConverter(ITeacherDisciplineStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public Data.Entity.Model.Status.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param)
        {
            Data.Entity.Model.Status.TeacherDisciplineStatus entity =
                new Data.Entity.Model.Status.TeacherDisciplineStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return entity;
        }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param,
          Data.Entity.Model.Status.TeacherDisciplineStatus oldEntity)
        {
            Data.Entity.Model.Status.TeacherDisciplineStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new Data.Entity.Model.Status.TeacherDisciplineStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
