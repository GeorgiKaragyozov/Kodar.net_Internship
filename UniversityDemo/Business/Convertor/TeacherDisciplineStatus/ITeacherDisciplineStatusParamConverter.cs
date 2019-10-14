using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusParamConverter
    {
        Data.Entity.Model.Status.TeacherDisciplineStatus Convert(AccountParam param);
    }
}
