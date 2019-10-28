using System;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter : IAccountStatusParamConverter
    {
        public IAccountStatusDao Dao = new AccountStatusDao();

        //public AccountStatusParamConverter(IAccountStatusDao dao)
        //{
        //    this.Dao = dao;
        //}

        public UniversityDemo.AccountStatus Convert(AccountStatusParam param)
        {
            UniversityDemo.AccountStatus status = new UniversityDemo.AccountStatus()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };

            return status;
        }

        public UniversityDemo.AccountStatus Convert(AccountStatusParam param, UniversityDemo.AccountStatus oldEntity)
        {
            UniversityDemo.AccountStatus entity;

            _ = oldEntity != null ? entity = oldEntity : entity = new UniversityDemo.AccountStatus();

            entity.Id = param.Id;
            entity.Code = param.Code;
            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
    }
}
