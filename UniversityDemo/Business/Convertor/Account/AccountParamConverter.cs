using System.Reflection;
using UniversityDemo.DataAccess.DataAccessObject.Account;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;
using UniversityDemo.DataAccess.DataAccessObject.User;
using System.Linq;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountParamConverter: BaseParamConverter<AccountParam, Model.Account> ,IAccountParamConverter 
    {
        IAccountDao Dao = new AccountDao();

        IUserDao UserDao = new UserDao();

        IAccountStatusDao StatusDao = new AccountStatusDao();

        public override Model.Account ConvertSpecific(AccountParam param, Model.Account entity)
        {
            throw new System.NotImplementedException();
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
                new Model.Account();
                //id
                //code      
            }

           ConvertStandart(param, entity);

            entity.User = UserDao.Find(param.UserId);
            entity.Status = StatusDao.Find(param.StatusId);

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
                PropertyInfo[] NamedPersistentProps = typeof(NamedPersistent).GetProperties()
                    .Where(p => p.Name != "Id" && p.Name != "Code").ToArray();

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
