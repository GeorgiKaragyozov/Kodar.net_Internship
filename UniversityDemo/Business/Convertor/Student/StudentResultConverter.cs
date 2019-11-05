namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentResultConverter : IStudentResultConverter
    {
        public StudentResult Convert(Model.Student param)
        {
            StudentResult result = new StudentResult()
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
                SpecialityId = param.Speciality.Id,
                SpecialityName = param.Speciality.Name
            };

            return result;
        }
    }
}
