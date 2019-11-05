using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.User;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Processor.User
{
    public class UserProcessor: IUserProcessor
    {
        public IUserDao Dao = new UserDao();

        public IUserParamConverter ParamConverter = new UserParamConverter();

        public IUserResultConverter ResultConverter = new UserResultConverter();

        //public UserProcessor(IUserDao dao, IUserParamConverter paramConverter,
        //    IUserResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public UserResult Create(UserParam param)
        {
            Model.User entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<UserResult> Create(List<UserParam> param)
        {
            List<Model.User> entities = new List<Model.User>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<UserResult> result = new List<UserResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.User> entities = new List<Model.User>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public UserResult Find(long id)
        {
            Model.User entity = Dao.Find(id);
            UserResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<UserResult> Find()
        {
            List<Model.User> entities = Dao.Find();

            List<UserResult> results = new List<UserResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, UserParam param)
        {
            Model.User oldEntity = Dao.Find(id);

            if (oldEntity != null)
            {
                Dao.Delete(oldEntity);
                Dao.Update(ParamConverter.Convert(param, null));
            }
            else
            {
                Console.WriteLine($"No entity with Id = {id}  was found");
            }
        }

        public void Update(List<UserParam> param)
        {
            //List<UniversityDemo.User> entities = new List<UniversityDemo.User>();

            foreach (var item in param)
            {
                Model.User oldEntity = Dao.Find(item.Id);
                Model.User newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
