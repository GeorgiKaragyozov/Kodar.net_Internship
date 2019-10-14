using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.UserStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.UserStatus
{
    public interface IUserStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(UserStatusParam param);
        ApiResponse Create(List<UserStatusParam> param);

        ApiResponse Update(long id, UserStatusParam param);
        ApiResponse Update(List<UserStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(UserStatusParam param);
        void ValidateParameters(List<UserStatusParam> param);
    }
}
