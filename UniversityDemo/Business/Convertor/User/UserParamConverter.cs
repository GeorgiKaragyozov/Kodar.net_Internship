using UniversityDemo.DataAccess.DataAccessObject.User;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserParamConverter: IUserParamConverter
    {
        IUserDao Dao = new UserDao();

        IUserStatusDao StatusDao = new UserStatusDao();

        public Model.User Convert(UserParam param, Model.User oldEntity)
        {
            Model.User entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.User
                {
                    Id = param.Id               
                };
            }

            entity.Password = param.Password;
            entity.Username = param.Username;
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }
    }
}
