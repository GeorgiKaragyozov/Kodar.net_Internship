using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Account
{
    public interface IAccountResultConverter : IBaseResultConverter<Model.Account, AccountResult>
    {
        AccountResult Convert(Model.Account param);
    }
}
