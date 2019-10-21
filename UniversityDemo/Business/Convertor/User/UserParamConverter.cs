using System;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserParamConverter: IUserParamConverter
    {
        public IUserDao Dao { get; set; }

        public UserParamConverter(IUserDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.User Convert(UserParam param)
        {
            throw new NotImplementedException();
        }
    }
}
