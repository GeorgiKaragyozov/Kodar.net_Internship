using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.UserStatus;

namespace UniversityDemo.Business.Processor.UserStatus
{
    public interface IUserStatusProcessor
    {
        UserStatusResult Create(UserStatusParam param);
        List<UserStatusResult> Create(List<UserStatusParam> param);

        void Update(long id, UserStatusParam param);
        void Update(List<UserStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        UserStatusResult Find(long id);
        List<UserStatusResult> Find();
    }
}
