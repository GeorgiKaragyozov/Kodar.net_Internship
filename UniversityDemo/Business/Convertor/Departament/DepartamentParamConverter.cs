using UniversityDemo.DataAccess.DataAccessObject.Departament;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;
using UniversityDemo.DataAccess.DataAccessObject.Teacher;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentParamConverter: IDepartamentParamConverter
    {
        ITeacherDao TeacherDao = new TeacherDao();

        ISpecialityDao SpecialityDao = new SpecialityDao();

        IDepartamentStatusDao StatusDao = new DepartamentStatusDao();

        public Model.Departament Convert(DepartamentParam param, Model.Departament oldEntity)
        {
            Model.Departament entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Departament()
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.Teacher = TeacherDao.Find(param.TeacherId);
            entity.Speciality = SpecialityDao.Find(param.SpecialityId);
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
