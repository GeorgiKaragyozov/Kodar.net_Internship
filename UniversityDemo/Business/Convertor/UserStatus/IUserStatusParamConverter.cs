﻿namespace UniversityDemo.Business.Convertor.UserStatus
{
    public interface IUserStatusParamConverter
    {
        UniversityDemo.UserStatus Convert(UserStatusParam param);

        UniversityDemo.UserStatus Convert(UserStatusParam param,
          UniversityDemo.UserStatus oldEntity);
    }
}
