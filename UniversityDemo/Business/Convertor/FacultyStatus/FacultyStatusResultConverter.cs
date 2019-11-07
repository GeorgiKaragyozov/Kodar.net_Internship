using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusResultConverter : IFacultyStatusResultConverter
    {
        public FacultyStatusResult Convert(Model.FacultyStatus param)
        {
            FacultyStatusResult result = new FacultyStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };

            return result;
        }
    }
}
