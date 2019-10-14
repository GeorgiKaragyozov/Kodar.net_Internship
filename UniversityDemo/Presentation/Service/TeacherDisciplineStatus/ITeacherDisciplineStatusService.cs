using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDisciplineStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(TeacherDisciplineStatusParam param);
        ApiResponse Create(List<TeacherDisciplineStatusParam> param);

        ApiResponse Update(long id, TeacherDisciplineStatusParam param);
        ApiResponse Update(List<TeacherDisciplineStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(TeacherDisciplineStatusParam param);
        void ValidateParameters(List<TeacherDisciplineStatusParam> param);
    }
}
