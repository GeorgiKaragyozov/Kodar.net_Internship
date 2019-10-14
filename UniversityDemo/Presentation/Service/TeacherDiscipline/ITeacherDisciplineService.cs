using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDiscipline;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.TeacherDiscipline
{
    public interface ITeacherDisciplineService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(TeacherDisciplineParam param);
        ApiResponse Create(List<TeacherDisciplineParam> param);

        ApiResponse Update(long id, TeacherDisciplineParam param);
        ApiResponse Update(List<TeacherDisciplineParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(TeacherDisciplineParam param);
        void ValidateParameters(List<TeacherDisciplineParam> param);
    }
}
