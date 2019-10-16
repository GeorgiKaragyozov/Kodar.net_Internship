using System;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public class UserStatusParamConverter: IUserStatusParamConverter
    {
        public UserStatusDao Dao { get; set; }

        public UniversityDemo.UserStatus Convert(UserStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
