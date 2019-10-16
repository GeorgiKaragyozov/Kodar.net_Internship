using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.User;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Processor.User
{
    public class UserProcessor: IUserProcessor
    {
        public UserDao Dao { get; set; }

        public UserParamConverter ParamConverter { get; set; }

        public UserResultConverter ResultConverter { get; set; }

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
