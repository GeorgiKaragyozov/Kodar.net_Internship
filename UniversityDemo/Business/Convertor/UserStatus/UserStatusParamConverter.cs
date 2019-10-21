using System;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public class UserStatusParamConverter: IUserStatusParamConverter
    {
        public IUserStatusDao Dao { get; set; }

        public UserStatusParamConverter(IUserStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.UserStatus Convert(UserStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
