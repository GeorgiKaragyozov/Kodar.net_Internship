using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Processor.Account
{
    public class AccountProcessor: IAccountProcessor
    {
        public AccountDao AccountDao { get; set; }

        public AccountParamConverter AccountParamConverter { get; set; }

        public AccountResultConverter AccountResultConverter { get; set; }
    }
}
