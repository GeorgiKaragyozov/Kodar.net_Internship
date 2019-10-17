using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.Business.Processor.Account;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Account
{
    public class AccountService: IAccountService
    {
        public AccountProcessor Processor { get; set; }

        public AccountService()
        {
            Processor = new AccountProcessor();
        }

        public ApiResponse Create(AccountParam param)
        {
            ApiResponse response = new ApiResponse();
            //if (!ValidateParameters(param))
            //{
            //    response.Result = false;
            //    response.Text = "Invalid parameters.";
            //    return response;
            //}

            try
            {
                AccountResult result = Processor.Create(param);

                response.Text = Serialization.Serizlize(result);

                //INTERNAL CHECK OF THE CONSISTENCY OF THE RESULT
                response.Result = true;

                //ApiResponse response = new ApiResponse() 
                //{ 
                //    Text = Serialization.Serialization.Serizlize(Processor.Create(param)),
                //    Result = true 
                //};
                
                //set text
                return response;
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;
                return response;
            }
        }

        public ApiResponse Create(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            ApiResponse response = new ApiResponse() 
            {
                Text = "Something",
                Result = true 
            };

            return response;
        }

        public ApiResponse FindByPk(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, AccountParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
