using System;
using UniversityDemo.Enums;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParam : BaseParamNamed
    {
        public UniversityDemo.SpecialityStatus Status { get; set; }

        public EducationalDegrees EducationalDegrees { get; set; }

        public TrainingType TrainingType { get; set; }

        public SpecialityParam(EducationalDegrees educationalDegree, TrainingType trainingType)
        {
            this.EducationalDegrees = educationalDegree;
            this.TrainingType = trainingType;
        }
    }
}
