using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Departament
{
    public interface IDepartamentParamConverter
    {
        UniversityDemo.Departament Convert(AccountParam param);
    }
}
