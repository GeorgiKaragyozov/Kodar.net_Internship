using System;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureParamConverter: ILectureParamConverter
    {
        public ILectureDao Dao = new LectureDao();

        //public LectureParamConverter(ILectureDao dao)
        //{
        //    this.Dao = dao;
        //}

        public Model.Lecture Convert(LectureParam param)
        {
            Model.Lecture entity = new Model.Lecture()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                TeacherDiscipline = param.TeacherDiscipline,
                Speciality = param.Speciality,
                Room = param.Room,
                Status = param.Status
            };

            return entity;
        }

        public Model.Lecture Convert(LectureParam param, Model.Lecture oldEntity)
        {
            Model.Lecture entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new Model.Lecture();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.TeacherDiscipline = param.TeacherDiscipline;
            entity.Speciality = param.Speciality;
            entity.Room = param.Room;
            entity.Status = param.Status;

            return entity;
        }
    }
}
