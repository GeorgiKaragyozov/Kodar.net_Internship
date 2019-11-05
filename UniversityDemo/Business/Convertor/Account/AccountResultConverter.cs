using System.Reflection;
using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountResultConverter : BaseResultConverter<Model.Account, AccountResult>, IAccountResultConverter
    {
        public override AccountResult ConvertSpecific(Model.Account param, AccountResult result)
        {
            throw new System.NotImplementedException();
        }

        public AccountResult Convert(Model.Account param)
        {
            AccountResult result = new AccountResult()
            {
                UserId = param.User.Id,
                UserName = param.User.Username,
                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };  

            ConvertStandart(param, result);

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

            //PropertyInfo[] ResultProp = typeof(AccountResult).GetProperties();
            //PropertyInfo[] ResultProp = result.GetType().GetProperties();

            //foreach (PropertyInfo property in ResultProp)
            //{
            //    //PropertyInfo propFrom = typeof(Model.Account).GetProperty(property.Name);

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
