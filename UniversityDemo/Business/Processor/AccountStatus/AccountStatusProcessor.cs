using System;
using UniversityDemo.Business.Convertor.AccountStatus;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Processor.AccountStatus
{
    public class AccountStatusProcessor: IAccountStatusProcessor
    {
        public AccountStatusDao AccountStatusDao { get; set; }

        public AccountStatusParamConverter AccountStatusParamConverter { get; set; }

        public AccountStatusResultConverter AccountStatusResultConverter { get; set; }        
    }
}
