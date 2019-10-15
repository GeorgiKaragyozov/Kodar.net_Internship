using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusParamConverter: IFacultyStatusParamConverter
    {
        public FacultyStatusDao FacultyStatusDao { get; set; }

        public UniversityDemo.FacultyStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
