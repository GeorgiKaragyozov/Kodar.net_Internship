using System;
using UniversityDemo.Business.Processor.Faculty;

namespace UniversityDemo.Presentation.Service.Faculty
{
    public class FacultyService: IFacultyService
    {
        public FacultyProcessor FacultyProcessor { get; set; }
    }
}
