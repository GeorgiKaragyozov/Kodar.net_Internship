using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.UserStatus;
using UniversityDemo.DataAccess.DataAccessObject.UserStatus;

namespace UniversityDemo.Business.Processor.UserStatus
{
    public class UserStatusProcessor: IUserStatusProcessor
    {
        public IUserStatusDao Dao { get; set; }

        public IUserStatusParamConverter ParamConverter { get; set; }

        public IUserStatusResultConverter ResultConverter { get; set; }

        public UserStatusProcessor(IUserStatusDao dao, IUserStatusParamConverter paramConverter,
            IUserStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public UserStatusResult Create(UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<UserStatusResult> Create(List<UserStatusParam> param)
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

        public UserStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
