using System;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountParamConverter: IAccountParamConverter
    {
        public IAccountDao Dao { get; set; }

        public AccountParamConverter(IAccountDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Account Convert(AccountParam param)
        {
            UniversityDemo.Account entity = new UniversityDemo.Account()
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

            return entity;
        }
    }
}
