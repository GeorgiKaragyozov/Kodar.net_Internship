using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherResultConverter : ITeacherResultConverter
    {
        public TeacherResult Convert(Model.Teacher param)
        {
            TeacherResult result = new TeacherResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,

                FirstName = param.FirstName,
                MiddleName = param.MiddleName,
                LastName = param.LastName,
                Egn = param.Egn,
                Address = param.Address,
                Country = param.Country,
                City = param.City,
                MobilePhone = param.MobilePhone,
                HomePhone = param.HomePhone,
                Email = param.Email,

                UserId = param.User.Id,
                UserName = param.User.Username,
                StatusId = param.Status.Id,
                StatusName = param.Status.Name,
            };

            return result;
        }
    }
}
