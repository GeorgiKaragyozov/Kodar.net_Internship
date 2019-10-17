using System;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountResultConverter : IAccountResultConverter
    {
        public AccountResult Convert(UniversityDemo.Account param)
        {
            AccountResult result = new AccountResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                FirstName = param.FirstName,
                MiddleName = param.MiddleName,
                LastName = param.LastName,
                Egn = param.Egn,
                Address = param.Address,
                Country = param.Country,
                MobilePhone = param.MobilePhone,
                HomePhone = param.HomePhone,
                User = param.User,
                Status = param.Status
            };

            return result;
        }
    }
}
