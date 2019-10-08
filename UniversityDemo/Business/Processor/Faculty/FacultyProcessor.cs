using System;
using UniversityDemo.Business.Convertor.Faculty;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Processor.Faculty
{
    public class FacultyProcessor: IFacultyProcessor
    {
        public FacultyDao FacultyDao { get; set; }

        public FacultyParamConverter FacultyParamConverter { get; set; }

        public FacultyResultConverter FacultyResultConverter { get; set; }       
    }
}
