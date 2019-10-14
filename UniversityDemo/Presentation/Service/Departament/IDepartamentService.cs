using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Departament;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Departament
{
    public interface IDepartamentService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(DepartamentParam param);
        ApiResponse Create(List<DepartamentParam> param);

        ApiResponse Update(long id, DepartamentParam param);
        ApiResponse Update(List<DepartamentParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(DepartamentParam param);
        void ValidateParameters(List<DepartamentParam> param);
    }
}
