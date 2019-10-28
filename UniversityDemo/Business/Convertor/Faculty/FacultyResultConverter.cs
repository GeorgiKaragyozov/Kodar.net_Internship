using System;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyResultConverter : IFacultyResultConverter
    {
        public FacultyResult Convert(UniversityDemo.Faculty param)
        {
            FacultyResult result = new FacultyResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Departament = param.Departament
            };

            return result;
        }
    }
}
