using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Convertor.Account
{
    public interface IAccountParamConverter
    {
        UniversityDemo.Account Convert(AccountParam param);
    }
}
