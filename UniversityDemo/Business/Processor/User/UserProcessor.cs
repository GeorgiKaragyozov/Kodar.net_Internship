using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.User;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Processor.User
{
    public class UserProcessor: IUserProcessor
    {
        public IUserDao Dao { get; set; }

        public IUserParamConverter ParamConverter { get; set; }

        public IUserResultConverter ResultConverter { get; set; }

        public UserProcessor(IUserDao dao, IUserParamConverter paramConverter,
            IUserResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public UserResult Create(UserParam param)
        {
            throw new NotImplementedException();
        }

        public List<UserResult> Create(List<UserParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public UserResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, UserParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<UserParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
