                      using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Account
{
    public interface IAccountService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(AccountParam param);
        ApiResponse Create(List<AccountParam> param);

        ApiResponse Update(long id, AccountParam param);
        ApiResponse Update(List<AccountParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(AccountParam param);
        void ValidateParameters(List<AccountParam> param);
    }
}
