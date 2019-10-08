using System;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserParamConverter: IUserParamConverter
    {
        public UserDao UserDao { get; set; }
    }
}
