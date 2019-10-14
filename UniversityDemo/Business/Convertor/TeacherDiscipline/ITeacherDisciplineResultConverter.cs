using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public interface ITeacherDisciplineResultConverter
    {
        AccountResult Convert(Model.TeacherDiscipline param);
    }
}
