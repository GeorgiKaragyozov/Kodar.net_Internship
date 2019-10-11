using System;
using UniversityDemo.Business.Processor.Account;
using UniversityDemo.Presentation.Serialization;

namespace UniversityDemo.Presentation.Service.Account
{
    public class AccountService<T>: Serialization<T> , IAccountService
    {
        public AccountProcessor AccountProcessor { get; set; }
    }
}
