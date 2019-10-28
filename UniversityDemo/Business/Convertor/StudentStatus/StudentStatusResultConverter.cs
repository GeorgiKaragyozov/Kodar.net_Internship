using System;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusResultConverter : IStudentStatusResultConverter
    {
        public StudentStatusResult Convert(UniversityDemo.StudentStatus param)
        {
            StudentStatusResult result = new StudentStatusResult()
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
