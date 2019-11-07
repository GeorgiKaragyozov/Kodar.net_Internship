using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusResultConverter :
        BaseResultConverter<Model.AccountStatus, AccountStatusResult>,
        IAccountStatusResultConverter
    {
        public AccountStatusResult Convert(Model.AccountStatus param)
        {
            AccountStatusResult result = new AccountStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };

            return result;
        }

        public override AccountStatusResult ConvertSpecific(Model.AccountStatus param, AccountStatusResult result)
        {
            throw new System.NotImplementedException();
        }
    }
}
