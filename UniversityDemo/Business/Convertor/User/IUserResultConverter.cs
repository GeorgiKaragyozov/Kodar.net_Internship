using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.User
{
    public interface IUserResultConverter
    {
        UserResult Convert(Model.User param);
    }
}
