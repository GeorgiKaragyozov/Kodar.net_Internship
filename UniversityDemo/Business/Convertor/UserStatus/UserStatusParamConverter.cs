using UniversityDemo.DataAccess.DataAccessObject.UserStatus;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public class UserStatusParamConverter: IUserStatusParamConverter
    {
        IUserStatusDao Dao = new UserStatusDao();

        public Model.UserStatus Convert(UserStatusParam param,
          Model.UserStatus oldEntity)
        {
            Model.UserStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.UserStatus()
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            };

            return entity;
        }
    }
}
