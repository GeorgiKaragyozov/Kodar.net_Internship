using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public interface ITeacherDisciplineParamConverter
    {
        Model.TeacherDiscipline Convert(AccountParam param);
    }
}
