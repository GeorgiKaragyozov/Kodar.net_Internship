using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.FacultyStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.FacultyStatus
{
    public interface IFacultyStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(FacultyStatusParam param);
        ApiResponse Create(List<FacultyStatusParam> param);

        ApiResponse Update(long id, FacultyStatusParam param);
        ApiResponse Update(List<FacultyStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(FacultyStatusParam param);
        void ValidateParameters(List<FacultyStatusParam> param);
    }
}
