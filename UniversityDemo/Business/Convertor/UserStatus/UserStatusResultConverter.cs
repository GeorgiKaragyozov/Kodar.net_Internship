using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public class UserStatusResultConverter : IUserStatusResultConverter
    {
        public UserStatusResult Convert(Model.UserStatus param)
        {
            UserStatusResult result = new UserStatusResult()
            {
                Id = param.Id,
                Name = param.Name,
                Code = param.Code,
                Description = param.Description
            };

            return result;
        }
    }
}
