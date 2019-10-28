using System;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserParamConverter: IUserParamConverter
    {
        public IUserDao Dao = new UserDao();

        //public UserParamConverter(IUserDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.User Convert(UserParam param)
        {
            UniversityDemo.User entity = new UniversityDemo.User()
            {
                Id = param.Id,
                Username = param.Username,
                Password = param.Password
            };

            return entity;
        }

        public UniversityDemo.User Convert(UserParam param,
          UniversityDemo.User oldEntity)
        {
            UniversityDemo.User entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.User();

            entity.Id = param.Id;
            entity.Password = param.Password;
            entity.Username = param.Username;

            return entity;
        }
    }
}
