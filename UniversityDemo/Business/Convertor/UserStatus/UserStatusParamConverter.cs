using System;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public class UserStatusParamConverter: IUserStatusParamConverter
    {
        public IUserStatusDao Dao = new UserStatusDao();

        //public UserStatusParamConverter(IUserStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.UserStatus Convert(UserStatusParam param)
        {
            UniversityDemo.UserStatus entity = new UniversityDemo.UserStatus()
            {
                Id = param.Id,
                Name = param.Name,
                Code = param.Code,
                Description = param.Description
            };

            return entity;
        }

        public UniversityDemo.UserStatus Convert(UserStatusParam param,
          UniversityDemo.UserStatus oldEntity)
        {
            UniversityDemo.UserStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.UserStatus();

            entity.Id = param.Id;
            entity.Name = param.Name;
            entity.Code = param.Code;
            entity.Description = param.Description;

            return entity;
        }
    }
}
