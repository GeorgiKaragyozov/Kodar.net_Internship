using UniversityDemo.DataAccess.DataAccessObject.Lecture;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;
using UniversityDemo.DataAccess.DataAccessObject.Room;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureParamConverter: ILectureParamConverter
    {
        ILectureDao Dao = new LectureDao();

        ITeacherDisciplineDao TeacherDisciplineDao = new TeacherDisciplineDao();

        ISpecialityDao SpecialityDao = new SpecialityDao();

        IRoomDao RoomDao = new RoomDao();

        ILectureStatusDao StatusDao = new LectureStatusDao();

        public Model.Lecture Convert(LectureParam param, Model.Lecture oldEntity)
        {
            Model.Lecture entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Lecture()
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.TeacherDiscipline = TeacherDisciplineDao.Find(param.TeacherDisciplineId);
            entity.Speciality = SpecialityDao.Find(param.SpecialityId);
            entity.Room = RoomDao.Find(param.RoomId);
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
