using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentResultConverter : IDepartamentResultConverter
    {
        public DepartamentResult Convert(Model.Departament param)
        {
            DepartamentResult result = new DepartamentResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,

                TeacherId = param.Teacher.Id,
                TeacherName = param.Teacher.Name,
                SpecialityId = param.Speciality.Id,
                SpecialityName = param.Speciality.Name,
                StatusId = param.Status.Id,
                StatusName = param.Status.Name
            };

            return result;
        }
    }
}
