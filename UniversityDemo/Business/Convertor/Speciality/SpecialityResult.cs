using System;
using UniversityDemo.Enums;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityResult : BaseResultNamed
    {
        public UniversityDemo.SpecialityStatus Status { get; set; }

        public EducationalDegrees EducationalDegrees { get; set; }

        public TrainingType TrainingType { get; set; }
    }
}
