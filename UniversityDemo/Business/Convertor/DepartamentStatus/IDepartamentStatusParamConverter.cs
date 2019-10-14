using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public interface IDepartamentStatusParamConverter
    {
        UniversityDemo.DepartamentStatus Convert(AccountParam param);
    }
}
