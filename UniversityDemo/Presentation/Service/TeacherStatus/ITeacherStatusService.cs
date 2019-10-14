using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.TeacherStatus
{
    public interface ITeacherStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(TeacherStatusParam param);
        ApiResponse Create(List<TeacherStatusParam> param);

        ApiResponse Update(long id, TeacherStatusParam param);
        ApiResponse Update(List<TeacherStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(TeacherStatusParam param);
        void ValidateParameters(List<TeacherStatusParam> param);
    }
}
