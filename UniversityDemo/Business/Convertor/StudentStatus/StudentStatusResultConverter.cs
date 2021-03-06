﻿using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public class StudentStatusResultConverter : IStudentStatusResultConverter
    {
        public StudentStatusResult Convert(Model.StudentStatus param)
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
