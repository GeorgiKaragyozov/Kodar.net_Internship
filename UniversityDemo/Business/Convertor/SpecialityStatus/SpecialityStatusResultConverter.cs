using System;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusResultConverter : ISpecialityStatusResultConverter
    {
        public SpecialityStatusResult Convert(UniversityDemo.SpecialityStatus param)
        {
            SpecialityStatusResult result = new SpecialityStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description
            };

            return result;
        }
    }
}
