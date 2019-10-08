using System;
using UniversityDemo.DataAccess.DataAccessObject.Faculty;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyParamConverter: IFacultyParamConverter
    {
        public FacultyDao FacultyDao { get; set; }
    }
}
