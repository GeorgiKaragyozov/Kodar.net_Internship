using UniversityDemo.DataAccess.DataAccessObject.Speciality;
using UniversityDemo.DataAccess.DataAccessObject.Student;
using UniversityDemo.DataAccess.DataAccessObject.StudentStatus;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParamConverter: IStudentParamConverter
    {
        IStudentDao Dao = new StudentDao();

        ISpecialityDao SpecialityDao = new SpecialityDao();

        IUserDao UserDao = new UserDao();

        IStudentStatusDao StatusDao = new StudentStatusDao();

        public Model.Student Convert(StudentParam param, Model.Student oldEntity)
        {
            Model.Student entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Student()
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.FirstName = param.FirstName;
            entity.LastName = param.LastName;
            entity.MiddleName = param.MiddleName;
            entity.Address = param.Address;
            entity.MobilePhone = param.MobilePhone;
            entity.HomePhone = param.HomePhone;
            entity.Email = param.Email;

            entity.User = UserDao.Find(param.UserId);
            entity.Speciality = SpecialityDao.Find(param.SpecialityId);
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
