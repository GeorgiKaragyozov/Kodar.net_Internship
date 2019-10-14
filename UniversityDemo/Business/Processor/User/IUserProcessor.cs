using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.User;

namespace UniversityDemo.Business.Processor.User
{
    public interface IUserProcessor
    {
        UserResult Create(UserParam param);
        List<UserResult> Create(List<UserParam> param);

        void Update(long id, UserParam param);
        void Update(List<UserParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        UserResult Find(long id);
        List<UserResult> Find();
    }
}
