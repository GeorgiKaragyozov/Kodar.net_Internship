using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityResultConverter : ISpecialityResultConverter
    {
        public SpecialityResult Convert(Model.Speciality param)
        {
            SpecialityResult result = new SpecialityResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,

                EducationalDegrees = param.EducationalDegrees,
                TrainingType = param.TrainingType,

                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };

            return result;
        }
    }
}
