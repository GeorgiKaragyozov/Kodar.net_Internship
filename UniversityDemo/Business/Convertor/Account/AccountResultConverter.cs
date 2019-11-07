using System.Reflection;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountResultConverter : BaseResultConverter<Model.Account, AccountResult>, IAccountResultConverter
    {
        public override AccountResult ConvertSpecific(Model.Account param, AccountResult result)
        {
            result.UserId = param.User.Id;
            result.UserName = param.User.Username;
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;

            return result;
        }

        public AccountResult Convert(Model.Account param)
        {
            AccountResult result = new AccountResult();

            result = ConvertStandart(param, result);
            result = ConvertSpecific(param, result);

            //----------------------- version 1 -----------------------//

            //PropertyInfo[] ResultProperties = typeof(AccountResult).GetProperties();

            //foreach (PropertyInfo propTo in ResultProperties)
            //{
            //    //PropertyInfo propFrom = typeof(Model.Account).GetProperty(propTo.Name);

            //    PropertyInfo propFrom = param.GetType().GetProperty(propTo.Name);

            //    if (propFrom != null && propFrom.CanWrite)
            //        propTo.SetValue(result, propFrom.GetValue(param, null), null);
            //}

            //----------------------- version 2 -----------------------//

            //PropertyInfo[] ResultProp = result.GetType().GetProperties();

            //foreach (PropertyInfo property in ResultProp)
            //{
            //    PropertyInfo propFrom = param.GetType().GetProperty(property.Name);

            //    //CanWrite true if this property can be written to
            //    if (propFrom != null && propFrom.CanWrite)
            //        typeof(AccountResult).GetProperty(property.Name).SetValue(result,
            //            typeof(Model.Account).GetProperty(property.Name).GetValue(param));
            //}

            return result;
        }

      
    }
}
