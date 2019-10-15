using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public class UserStatusParamConverter: IUserStatusParamConverter
    {
        public UserStatusDao UserStatusDao { get; set; }

        public UniversityDemo.UserStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
