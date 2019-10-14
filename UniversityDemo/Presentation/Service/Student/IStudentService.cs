using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Student;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Student
{
    public interface IStudentService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(StudentParam param);
        ApiResponse Create(List<StudentParam> param);

        ApiResponse Update(long id, StudentParam param);
        ApiResponse Update(List<StudentParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(StudentParam param);
        void ValidateParameters(List<StudentParam> param);
    }
}
