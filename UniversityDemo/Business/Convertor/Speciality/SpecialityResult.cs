using UniversityDemo.Enums;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityResult : BaseResultNamed
    {
        public long StatusId { get; set; }
        public string StatusName { get; set; }

        public EducationalDegrees EducationalDegrees { get; set; }
        public TrainingType TrainingType { get; set; }
    }
}
