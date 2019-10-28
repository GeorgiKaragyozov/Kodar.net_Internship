using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Teacher;
using UniversityDemo.Business.Processor.Teacher;
using UniversityDemo.Data.Common;
using UniversityDemo.Presentation;
using UniversityDemo.Presentation.Service.Teacher;

namespace UniversityDemoPresentation.Service.Teacher
{
    public class TeacherService: ITeacherService
    {
        public ITeacherProcessor Processor = new TeacherProcessor();

        //public TeacherService(ITeacherProcessor processor)
        //{
        //    this.Processor = processor;
        //}

        /// <summary>
        /// Function to create new a entity .
        /// </summary>
        /// <param name="param">a entity</param>
        /// <returns>response and new entity</returns>
        public ApiResponse Create(TeacherParam param)
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
        public ApiResponse Create(List<TeacherParam> param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                response.Text = $"The entities successfully added .\n " +
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
            catch (Exception ex)
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
                List<TeacherResult> results = Processor.Find();
                response.Text = $"Тhe list of entities was found successfully . \n" +
                $"{Serialization.Serizlize(results)}";
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
        /// Function to update information about a entity .
        /// </summary>
        /// <param name="id">entity's id</param>
        /// <param name="param">entity</param>
        /// <returns>response and update entity</returns>
        public ApiResponse Update(long id, TeacherParam param)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                Processor.Update(id, param);
                response.Text = "The entity updated successfully . \n";
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
        /// Function to update information about entities .
        /// </summary>
        /// <param name="param">entities</param>
        /// <returns>response and update entities</returns> 
        public ApiResponse Update(List<TeacherParam> param)
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
        public void ValidateParameters(TeacherParam param)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">entities</param>
        public void ValidateParameters(List<TeacherParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
