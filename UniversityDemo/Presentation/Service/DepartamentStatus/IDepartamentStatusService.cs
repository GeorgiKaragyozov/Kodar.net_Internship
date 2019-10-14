using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DepartamentStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.DepartamentStatus
{
    public interface IDepartamentStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(DepartamentStatusParam param);
        ApiResponse Create(List<DepartamentStatusParam> param);

        ApiResponse Update(long id, DepartamentStatusParam param);
        ApiResponse Update(List<DepartamentStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(DepartamentStatusParam param);
        void ValidateParameters(List<DepartamentStatusParam> param);
    }
}
