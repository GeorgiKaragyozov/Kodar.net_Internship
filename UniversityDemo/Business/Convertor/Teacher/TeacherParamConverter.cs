using UniversityDemo.DataAccess.DataAccessObject.Teacher;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;
using UniversityDemo.DataAccess.DataAccessObject.User;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherParamConverter: ITeacherParamConverter
    {
        ITeacherDao Dao = new TeacherDao();

        IUserDao UserDao = new UserDao();

        ITeacherStatusDao StatusDao = new TeacherStatusDao();

        public Model.Teacher Convert(TeacherParam param, Model.Teacher oldEntity)
        {
            Model.Teacher entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Teacher()
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
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
