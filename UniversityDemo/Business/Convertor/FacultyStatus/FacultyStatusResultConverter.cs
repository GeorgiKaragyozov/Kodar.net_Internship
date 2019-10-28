using System;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public class FacultyStatusResultConverter : IFacultyStatusResultConverter
    {
        public FacultyStatusResult Convert(UniversityDemo.FacultyStatus param)
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
