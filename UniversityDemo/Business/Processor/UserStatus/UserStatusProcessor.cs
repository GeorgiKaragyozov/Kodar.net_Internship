using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.Business.Convertor.UserStatus;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;

namespace UniversityDemo.Business.Processor.UserStatus
{
    public class UserStatusProcessor: IUserStatusProcessor
    {
        public TeacherStatusDao TeacherDao { get; set; }

        public TeacherStatusParamConverter TeacherParamConverter { get; set; }

        public TeacherStatusResultConverter TeacherResultConverter { get; set; }

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
