using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.User;
using UniversityDemo.Business.Processor.User;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.User
{
    public class UserService: IUserService
    {
        public UserProcessor Processor { get; set; }

        public ApiResponse Create(UserParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<UserParam> param)
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

        public ApiResponse Update(long id, UserParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<UserParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
