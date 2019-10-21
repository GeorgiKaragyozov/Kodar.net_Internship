using System;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter: IAccountStatusParamConverter
    {
        public IAccountStatusDao Dao { get; set; }

        public AccountStatusParamConverter(IAccountStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.AccountStatus Convert(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
