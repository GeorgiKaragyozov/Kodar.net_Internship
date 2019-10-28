using System;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserResultConverter : IUserResultConverter
    {
        public UserResult Convert(UniversityDemo.User param)
        {
            UserResult result = new UserResult()
            {
                Id = param.Id,
                Username = param.Username,
                Password = param.Password
            };

            return result;
        }
    }
}
