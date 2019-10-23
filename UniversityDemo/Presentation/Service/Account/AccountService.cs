using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.Business.Processor.Account;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Account
{
    public class AccountService: IAccountService
    {
        public IAccountProcessor Processor = new AccountProcessor();

        //public AccountService(IAccountProcessor processor)
        //{
        //    this.Processor = processor;
        //}

        public ApiResponse Create(AccountParam param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                response.Text = $"Account successfully added .\n" +
                    $" {Serialization.Serizlize(Processor.Create(param))}";

                response.Result = true;

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
            ApiResponse response = new ApiResponse();

            try
            {
                response.Text = Serialization.Serizlize(Processor.Create(param));
                response.Result = true;

                return response;
            }
            catch(Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
        }

        public ApiResponse Delete(List<long> idList)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Delete(idList);
                response.Text = "The entity was successfully removed .";
                response.Result = true;

                return response;
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
        }

        public ApiResponse DeleteById(long id)
        {
            ApiResponse response = new ApiResponse();

            try
            {              
                Processor.Delete(id);
                response.Text = $"The entity with id = " +
                    $"{id} was successfully deleted .";
                response.Result = true;

                return response;
            }
            catch(Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }          
        }

        public ApiResponse FindByPk(long id)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Find(id);
                response.Text = $"Account with this primary key was found . \n" +
                    $"{Serialization.Serizlize(Processor.Find(id))}";

                response.Result = true;

                return response;
            }
            catch(Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
        }

        public ApiResponse FindByName(string name)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                List<AccountResult> results = Processor.Find(name);

                response.Text = Serialization.Serizlize(results);
                response.Result = true;

                return response;
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
        }

        public ApiResponse ListAll()
        {
            ApiResponse response = new ApiResponse();

            try
            {
                List<AccountResult> results = Processor.Find();
                response.Text = Serialization.Serizlize(results);
                response.Result = true;

                return response;
            }
            catch(Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
        }

        public ApiResponse Update(long id, AccountParam param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Update(id, param);
                response.Result = true;
                response.Text = "The entity has been updated.";

                return response;
            }
            catch(Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
        }

        public ApiResponse Update(List<AccountParam> param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Update(param);
                response.Result = true;
                response.Text = "The entity has been updated.";

                return response;
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
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
