using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public interface IDisciplineResultConverter
    {
        AccountResult Convert(UniversityDemo.Discipline param);
    }
}
