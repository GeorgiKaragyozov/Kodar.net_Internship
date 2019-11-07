using UniversityDemo.DataAccess.DataAccessObject.Discipline;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineParamConverter: ITeacherDisciplineParamConverter
    {
        ITeacherDisciplineDao Dao = new TeacherDisciplineDao();

        ITeacherDao TeacherDao = new TeacherDao();

        IDisciplineDao DisciplineDao = new DisciplineDao();

        ITeacherDisciplineStatusDao StatusDao = new TeacherDisciplineStatusDao();

        public Model.TeacherDiscipline Convert(TeacherDisciplineParam param,
          Model.TeacherDiscipline oldEntity)
        {
            Model.TeacherDiscipline entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.TeacherDiscipline()
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.Teacher = TeacherDao.Find(param.TeacherId);
            entity.Discipline = DisciplineDao.Find(param.DisciplineId);
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
