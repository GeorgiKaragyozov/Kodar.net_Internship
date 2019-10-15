using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.UserStatus;
using UniversityDemo.Business.Processor.UserStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.UserStatus
{
    public class UserStatusService: IUserStatusService
    {
        public UserStatusProcessor Processor { get; set; }

        public ApiResponse Create(UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPk(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
