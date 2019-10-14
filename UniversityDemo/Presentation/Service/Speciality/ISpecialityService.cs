using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Speciality;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Speciality
{
    public interface ISpecialityService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(SpecialityParam param);
        ApiResponse Create(List<SpecialityParam> param);

        ApiResponse Update(long id, SpecialityParam param);
        ApiResponse Update(List<SpecialityParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(SpecialityParam param);
        void ValidateParameters(List<SpecialityParam> param);
    }
}
