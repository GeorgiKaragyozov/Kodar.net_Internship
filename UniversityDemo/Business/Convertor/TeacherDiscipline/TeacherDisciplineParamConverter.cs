using System;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineParamConverter: ITeacherDisciplineParamConverter
    {
        public ITeacherDisciplineDao Dao = new TeacherDisciplineDao();

        //public TeacherDisciplineParamConverter(ITeacherDisciplineDao dao)
        //{
        //    this.Dao = dao;
        //}

        public Model.TeacherDiscipline Convert(TeacherDisciplineParam param)
        {
            Model.TeacherDiscipline entity = new Model.TeacherDiscipline()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Teacher = param.Teacher,
                Discipline = param.Discipline,
                Status = param.Status
            };

            return entity;
        }

        public Model.TeacherDiscipline Convert(TeacherDisciplineParam param,
          Model.TeacherDiscipline oldEntity)
        {
            Model.TeacherDiscipline entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new Model.TeacherDiscipline();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Status = param.Status;
            entity.Teacher = param.Teacher;
            entity.Discipline = param.Discipline;

            return entity;
        }
    }
}
