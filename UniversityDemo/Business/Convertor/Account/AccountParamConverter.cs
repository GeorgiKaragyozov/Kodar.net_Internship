using System;
using Newtonsoft.Json;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountParamConverter: IAccountParamConverter
    {
        public AccountDao AccountDao { get; set; }

        public UniversityDemo.Account Convert(AccountParam param)
        {
            return JsonConvert.DeserializeObject<UniversityDemo.Account>(param.Input);
        }
    }
}
