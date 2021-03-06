﻿using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.UserStatus;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;

namespace UniversityDemo.Business.Processor.UserStatus
{
    public class UserStatusProcessor: IUserStatusProcessor
    {
        public IUserStatusDao Dao = new UserStatusDao();

        public IUserStatusParamConverter ParamConverter = new UserStatusParamConverter();

        public IUserStatusResultConverter ResultConverter = new UserStatusResultConverter();

        //public UserStatusProcessor(IUserStatusDao dao, IUserStatusParamConverter paramConverter,
        //    IUserStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public UserStatusResult Create(UserStatusParam param)
        {
            Model.UserStatus entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<UserStatusResult> Create(List<UserStatusParam> param)
        {
            List<Model.UserStatus> entities = new List<Model.UserStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<UserStatusResult> result = new List<UserStatusResult>();

            entities.ForEach(dep => result.Add(ResultConverter.Convert(dep)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Model.UserStatus> entities = new List<Model.UserStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public UserStatusResult Find(long id)
        {
            Model.UserStatus entity = Dao.Find(id);
            UserStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<UserStatusResult> Find()
        {
            List<Model.UserStatus> entities = Dao.Find();

            List<UserStatusResult> results = new List<UserStatusResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, UserStatusParam param)
        {
            Model.UserStatus oldEntity = Dao.Find(id);

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

        public void Update(List<UserStatusParam> param)
        {
            //List<UniversityDemo.UserStatus> entities = new List<UniversityDemo.UserStatus>();

            foreach (var item in param)
            {
                Model.UserStatus oldEntity = Dao.Find(item.Id);
                Model.UserStatus newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }
        }
    }
}
