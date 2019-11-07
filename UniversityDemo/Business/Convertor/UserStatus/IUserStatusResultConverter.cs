using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public interface IUserStatusResultConverter
    {
        UserStatusResult Convert(Model.UserStatus param);
    }
}
