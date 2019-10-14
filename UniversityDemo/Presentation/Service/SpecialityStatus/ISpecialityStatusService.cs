using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.SpecialityStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.SpecialityStatus
{
    public interface ISpecialityStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(SpecialityStatusParam param);
        ApiResponse Create(List<SpecialityStatusParam> param);

        ApiResponse Update(long id, SpecialityStatusParam param);
        ApiResponse Update(List<SpecialityStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(SpecialityStatusParam param);
        void ValidateParameters(List<SpecialityStatusParam> param);
    }
}
