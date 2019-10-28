using System;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityResultConverter : ISpecialityResultConverter
    {
        public SpecialityResult Convert(UniversityDemo.Speciality param)
        {
            SpecialityResult result = new SpecialityResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status,
                EducationalDegrees = param.EducationalDegrees,
                TrainingType = param.TrainingType
            };

            return result;
        }
    }
}
