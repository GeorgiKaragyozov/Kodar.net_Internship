using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Teacher;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Teacher
{
    public interface ITeacherService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(TeacherParam param);
        ApiResponse Create(List<TeacherParam> param);

        ApiResponse Update(long id, TeacherParam param);
        ApiResponse Update(List<TeacherParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(TeacherParam param);
        void ValidateParameters(List<TeacherParam> param);
    }
}
