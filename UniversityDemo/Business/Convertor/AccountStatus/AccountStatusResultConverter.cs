using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusResultConverter : IAccountStatusResultConverter
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
    }
}
