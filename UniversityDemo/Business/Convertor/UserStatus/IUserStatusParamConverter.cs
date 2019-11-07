using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public interface IUserStatusParamConverter
    {
        Model.UserStatus Convert(UserStatusParam param, Model.UserStatus oldEntity);
    }
}
