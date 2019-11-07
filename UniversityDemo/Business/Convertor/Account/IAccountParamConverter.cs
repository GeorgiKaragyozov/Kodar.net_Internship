using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Account
{
    public interface IAccountParamConverter : IBaseParamConverter<AccountParam, Model.Account>
    {
        Model.Account Convert(AccountParam param, Model.Account oldEntity);
    }
}
