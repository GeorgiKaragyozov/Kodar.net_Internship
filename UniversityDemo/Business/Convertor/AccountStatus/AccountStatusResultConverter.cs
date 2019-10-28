using System;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusResultConverter : IAccountStatusResultConverter
    {
        public AccountStatusResult Convert(UniversityDemo.AccountStatus param)
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
