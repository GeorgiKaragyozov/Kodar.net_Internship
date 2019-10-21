using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.AccountStatus;
using UniversityDemo.Business.Processor.AccountStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.AccountStatus
{
    public class AccountStatusService: IAccountStatusService
    {
        public IAccountStatusProcessor Processor { get; set; }

        public AccountStatusService(IAccountStatusProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPk(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
