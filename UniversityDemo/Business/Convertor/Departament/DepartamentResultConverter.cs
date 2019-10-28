using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentResultConverter : IDepartamentResultConverter
    {
        public DepartamentResult Convert(UniversityDemo.Departament param)
        {
            DepartamentResult result = new DepartamentResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Speciality = param.Speciality,
                Teacher = param.Teacher,
                Status = param.Status
            };

            return result;
        }
    }
}
