using System;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherResultConverter : ITeacherResultConverter
    {
        public TeacherResult Convert(UniversityDemo.Teacher param)
        {
            TeacherResult result = new TeacherResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Status = param.Status,
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
