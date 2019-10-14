using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.User;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.User
{
    public interface IUserService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(UserParam param);
        ApiResponse Create(List<UserParam> param);

        ApiResponse Update(long id, UserParam param);
        ApiResponse Update(List<UserParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(UserParam param);
        void ValidateParameters(List<UserParam> param);
    }
}
