using System;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserParamConverter: IUserParamConverter
    {
        public UserDao Dao { get; set; }

        public UniversityDemo.User Convert(UserParam param)
        {
            throw new NotImplementedException();
        }
    }
}
