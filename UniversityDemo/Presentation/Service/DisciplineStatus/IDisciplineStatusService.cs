using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DisciplineStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.DisciplineStatus
{
    public interface IDisciplineStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(DisciplineStatusParam param);
        ApiResponse Create(List<DisciplineStatusParam> param);

        ApiResponse Update(long id, DisciplineStatusParam param);
        ApiResponse Update(List<DisciplineStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(DisciplineStatusParam param);
        void ValidateParameters(List<DisciplineStatusParam> param);
    }
}
