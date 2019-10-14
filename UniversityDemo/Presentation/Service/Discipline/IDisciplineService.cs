using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Discipline;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Discipline
{
    public interface IDisciplineService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(DisciplineParam param);
        ApiResponse Create(List<DisciplineParam> param);

        ApiResponse Update(long id, DisciplineParam param);
        ApiResponse Update(List<DisciplineParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(DisciplineParam param);
        void ValidateParameters(List<DisciplineParam> param);
    }
}
