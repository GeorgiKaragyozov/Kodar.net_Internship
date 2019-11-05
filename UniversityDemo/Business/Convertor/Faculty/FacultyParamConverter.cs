using UniversityDemo.DataAccess.DataAccessObject.Departament;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyParamConverter: IFacultyParamConverter
    {
        IFacultyDao Dao = new FacultyDao();

        IDepartamentDao DepartamentDao = new DepartamentDao();

        IFacultyStatusDao StatusDao = new FacultyStatusDao();

        public Model.Faculty Convert(FacultyParam param, Model.Faculty oldEntity)
        {
            Model.Faculty entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Faculty
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.Departament = DepartamentDao.Find(param.DepartamentId);
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
