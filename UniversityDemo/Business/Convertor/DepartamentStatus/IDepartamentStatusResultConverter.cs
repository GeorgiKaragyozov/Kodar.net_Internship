using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public interface IDepartamentStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.DepartamentStatus param);
    }
}
