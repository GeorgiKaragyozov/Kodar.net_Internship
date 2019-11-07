using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public interface IAccountStatusParamConverter : IBaseParamConverter<AccountStatusParam, Model.AccountStatus>
    {
        Model.AccountStatus Convert(AccountStatusParam param, Model.AccountStatus oldEntity);
    }
}
