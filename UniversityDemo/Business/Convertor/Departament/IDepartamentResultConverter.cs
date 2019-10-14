using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Departament
{
    public interface IDepartamentResultConverter
    {
        AccountResult Convert(UniversityDemo.Departament param);
    }
}
