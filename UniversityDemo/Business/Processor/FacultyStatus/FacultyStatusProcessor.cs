using System;
using UniversityDemo.Business.Convertor.FacultyStatus;
using UniversityDemo.DataAccess.DataAccessObject.FacultyStatus;

namespace UniversityDemo.Business.Processor.FacultyStatus
{
    public class FacultyStatusProcessor: IFacultyStatusProcessor
    {
        public FacultyStatusDao FacultyStatusDao { get; set; }

        public FacultyStatusParamConverter FacultyStatusParamConverter { get; set; }

        public FacultyStatusResultConverter FacultyStatusResultConverter { get; set; }        
    }
}
