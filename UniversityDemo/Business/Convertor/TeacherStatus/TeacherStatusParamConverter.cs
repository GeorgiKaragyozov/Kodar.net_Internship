using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.TeacherStatus;
using UniversityDemo.Model.Accounts;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public class TeacherStatusParamConverter: ITeacherStatusParamConverter
    {
        public TeacherStatusDao TeacherStatusDao { get; set; }

        public Model.Accounts.TeacherStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
