using System;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusParamConverter: IFacultyStatusParamConverter
    {
        public FacultyStatusDao FacultyStatusDao { get; set; }
    }
}
