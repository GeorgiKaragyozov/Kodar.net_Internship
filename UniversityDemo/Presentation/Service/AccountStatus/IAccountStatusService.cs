using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.AccountStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.AccountStatus
{
    public interface IAccountStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(AccountStatusParam param);
        ApiResponse Create(List<AccountStatusParam> param);

        ApiResponse Update(long id, AccountStatusParam param);
        ApiResponse Update(List<AccountStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(AccountStatusParam param);
        void ValidateParameters(List<AccountStatusParam> param);
    }
}
