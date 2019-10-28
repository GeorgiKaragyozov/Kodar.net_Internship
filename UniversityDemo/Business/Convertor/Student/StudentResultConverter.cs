using System;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentResultConverter : IStudentResultConverter
    {
        public StudentResult Convert(UniversityDemo.Student param)
        {
            StudentResult result = new StudentResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status,
                Speciality = param.Speciality,
                FirstName = param.FirstName,
                MiddleName = param.MiddleName,
                LastName = param.LastName,
                Egn = param.Egn,
                Address = param.Address,
                Country = param.Country,
                MobilePhone = param.MobilePhone,
                HomePhone = param.HomePhone,
                User = param.User
            };

            return result;
        }
    }
}
