using System;
using UniversityDemo.Business.Processor.Account;

namespace UniversityDemo.Presentation.Service.Account
{
    public class AccountService: IAccountService
    {
        public AccountProcessor AccountProcessor { get; set; }
    }
}
