using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusResultConverter : ISpecialityStatusResultConverter
    {
        public SpecialityStatusResult Convert(Model.SpecialityStatus param)
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
