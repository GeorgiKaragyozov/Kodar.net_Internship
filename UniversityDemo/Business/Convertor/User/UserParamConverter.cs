using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserParamConverter: IUserParamConverter
    {
        public UserDao UserDao { get; set; }

        public UniversityDemo.User Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
