using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.Business.Processor.Account;
using UniversityDemo.Data.Common;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Presentation.Service.Account
{
    public class AccountService: IAccountService
    {
        public IAccountProcessor Processor = new AccountProcessor();

        //public AccountService(IAccountProcessor processor)
        //{
        //    this.Processor = processor;
        //}

        /// <summary>
        /// Function to create new a entity .
        /// </summary>
        /// <param name="param">a entity</param>
        /// <returns>response and new entity</returns>
        public ApiResponse Create(AccountParam param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                response.Text = $"The entity successfully added .\n" +
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

        /// <summary>
        /// Function to create new entities .
        /// </summary>
        /// <param name="param">entities</param>
        /// <returns>responce and entities</returns>
        public ApiResponse Create(List<AccountParam> param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                response.Text = $"The entities successfully added .\n " +
                    $" {Serialization.Serizlize(Processor.Create(param))}";
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

        /// <summary>
        /// Function to delete entities .
        /// </summary>
        /// <param name="idList">entities id</param>
        /// <returns>response</returns>
        public ApiResponse Delete(List<long> idList)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Delete(idList);
                response.Text = "The entity was successfully removed . \n";
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

        /// <summary>
        /// Function to delete a entity .
        /// </summary>
        /// <param name="id">entity's id</param>
        /// <returns>response</returns>
        public ApiResponse DeleteById(long id)
        {
            ApiResponse response = new ApiResponse();

            try
            {              
                Processor.Delete(id);
                response.Text = $"The entity with id = " +
                    $"{id} was successfully deleted . \n";
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

        /// <summary>
        /// Function to find an entity by id .
        /// </summary>
        /// <param name="id">entity id</param>
        /// <returns>response and information about the entity</returns>
        public ApiResponse FindByPk(long id)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Find(id);
                response.Text = $"Entity with this primary key < {id} > was found . \n" +
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

        /// <summary>
        ///  Function to find an entity by name .
        /// </summary>
        /// <param name="name">entity's name</param>
        /// <returns>response and information about the entity</returns>
        public ApiResponse FindByName(string name)
        {
            if (name == null)
            {
                throw new ArgumentException("Name is null");
            }

            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Find(name);
                response.Text = $"Entity with this name < {name} > was found . \n" +
                    $"{Serialization.Serizlize(Processor.Find(name))}";
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

        /// <summary>
        /// Function to find an entity by code .
        /// </summary>
        /// <param name="code">entity's code</param>
        /// <returns>response and information about the entity</returns>
        public ApiResponse FindByCode(string code)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                response.Text = $"Entity with this code < {code} > was found . \n" +
                    $"{Serialization.Serizlize(Processor.FindByCode(code))}";
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

        /// <summary>
        /// Function to find an entity by description .
        /// </summary>
        /// <param name="description">entity's description</param>
        /// <returns></returns>
        public ApiResponse FindByDescription(string description)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                response.Text = $"Entity with this description < {description} > was found . \n" +
                    $"{Serialization.Serizlize(Processor.FindByDescription(description))}";
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

        /// <summary>
        /// Function to find all created entities and print their information .
        /// </summary>
        /// <returns>entities</returns>
        public ApiResponse ListAll()
        {
            ApiResponse response = new ApiResponse();

            try
            {
                List<AccountResult> results = Processor.Find();
                response.Text = $"Тhe list of entities was found successfully . \n" +
                    $"{Serialization.Serizlize(results)}";
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

        /// <summary>
        /// Function to update information about a entity .
        /// </summary>
        /// <param name="id">entity's id</param>
        /// <param name="param">entity</param>
        /// <returns>response and update entity</returns>
        public ApiResponse Update(long id, AccountParam param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Update(id, param);
                response.Result = true;
                response.Text = "The entity updated successfully . \n";

                return response;
            }
            catch(Exception ex)
            {
                response.Result = false;
                response.Text = ex.Message;

                return response;
            }
        }

        /// <summary>
        /// Function to update information about entities .
        /// </summary>
        /// <param name="param">entities</param>
        /// <returns>response and update entities</returns>
        public ApiResponse Update(List<AccountParam> param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Update(param);
                response.Text = "The entities have been updated.\n";
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">a entity</param>
        public void ValidateParameters(AccountParam param)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">entities</param>
        public void ValidateParameters(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
