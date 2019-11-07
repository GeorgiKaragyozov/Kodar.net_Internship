using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.User
{
    public interface IUserParamConverter
    {
        Model.User Convert(UserParam param, Model.User oldEntity);
    }
}
