using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public interface IAccountStatusResultConverter : IBaseResultConverter<AccountStatusResult, Model.AccountStatus>
    {
        AccountStatusResult Convert(Model.AccountStatus param);
    }
}
