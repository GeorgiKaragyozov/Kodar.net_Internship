using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.Data.Entity.Model.Status;
using UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusParamConverter: ITeacherDisciplineStatusParamConverter
    {
        public TeacherDisciplineStatusDao TeacherDisciplineStatusDao { get; set; }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
