using System.Linq;
using System.Reflection;
using UniversityDemo.Business.Convertor.Common;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;
using UniversityDemo.DataAccess.DataAccessObject.User;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountParamConverter : BaseParamConverter<AccountParam, Model.Account>, IAccountParamConverter
    {
        private IUserDao UserDao = new UserDao();

        private IAccountStatusDao StatusDao = new AccountStatusDao();

        public override Model.Account ConvertSpecific(AccountParam param, Model.Account entity)
        {
            entity.User = UserDao.Find(param.UserId);
            entity.Status = StatusDao.Find(param.StatusId);

            return entity;
        }

        public Model.Account Convert(AccountParam param, Model.Account oldEntity)
        {
            Model.Account entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Model.Account();
                
                entity.Id = param.Id;
                entity.Code = param.Code;         
            }

            entity = ConvertStandart(param, entity);
            entity = ConvertSpecific(param, entity);

            return entity;
        }

        public static Model.Account ParamToAccount(AccountParam param, Model.Account oldEntity)
        {
            Model.Account entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                PropertyInfo[] NamedPersistentProps = typeof(NamedPersistent).GetProperties();

                entity = new Model.Account();

                foreach (PropertyInfo property in NamedPersistentProps)
                {
                    typeof(Model.Account).GetProperty(property.Name).SetValue(entity,
                        typeof(AccountParam).GetProperty(property.Name).GetValue(param));
                }
            }

            PropertyInfo[] AccountParamProps = typeof(AccountParam).GetProperties()
               .Where(p1 => typeof(Model.Account).GetProperties().Any(p2 => p2.Name == p1.Name))
               .ToArray();

            foreach (PropertyInfo prop in AccountParamProps)
            {
                typeof(Model.Account).GetProperty(prop.Name).SetValue(entity,
                     typeof(AccountParam).GetProperty(prop.Name).GetValue(param));
            }

            return entity;
        }
    }
}
