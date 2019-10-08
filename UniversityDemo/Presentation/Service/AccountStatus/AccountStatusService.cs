using System;
using UniversityDemo.Business.Processor.AccountStatus;

namespace UniversityDemo.Presentation.Service.AccountStatus
{
    public class AccountStatusService: IAccountStatusService
    {
        public AccountStatusProcessor AccountStatusProcessor { get; set; }
    }
}
