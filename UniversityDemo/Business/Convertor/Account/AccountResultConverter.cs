using Newtonsoft.Json;
using System;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountResultConverter : IAccountResultConverter
    {
        public AccountResult Convert(UniversityDemo.Account param)
        {
            AccountResult result = new AccountResult() 
            {
                Converted = JsonConvert.SerializeObject(param) 
            };

            return result;
        }
    }
}
