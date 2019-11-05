using UniversityDemo.Enums;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParam : BaseParamNamed
    {
        public long StatusId { get; set; }

        public EducationalDegrees EducationalDegrees { get; set; }

        public TrainingType TrainingType { get; set; }      
    }
}
