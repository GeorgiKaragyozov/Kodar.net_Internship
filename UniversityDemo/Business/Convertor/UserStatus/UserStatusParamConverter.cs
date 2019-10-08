using System;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public class UserStatusParamConverter: IUserStatusParamConverter
    {
        public UserStatusDao UserStatusDao { get; set; }
    }
}
