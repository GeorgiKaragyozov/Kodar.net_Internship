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
                //Processor = new AccountProcessor();
                AccountResult result = Processor.Create(param);

                //INTERNAL CHECK OF THE CONSISTENCY OF THE RESULT
                response.Result = true;

                //set text
                return response;
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;
                return response;
            }

            //ApiResponse response = new ApiResponse();
            //AccountResult result = Processor.Create(param);

            //if (true) //ako accountresult vryshta OK
            //{
            //    response.Result = true;
            //    //set text
            //}
            //else
            //{
            //    response.Result = false;
            //    response.Text = result.ToString();
            //}

            //return response;
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

        //protected bool ValidateParameters(AccountParam param)
        //{
        //    throw new NotImplementedException();
        //}

        public void ValidateParameters(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
