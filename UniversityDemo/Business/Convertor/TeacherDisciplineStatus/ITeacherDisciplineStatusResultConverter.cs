using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusResultConverter
    {
        AccountResult Convert(Data.Entity.Model.Status.TeacherDisciplineStatus param);
    }
}
