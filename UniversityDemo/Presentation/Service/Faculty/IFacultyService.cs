using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Faculty;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Faculty
{
    public interface IFacultyService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(FacultyParam param);
        ApiResponse Create(List<FacultyParam> param);

        ApiResponse Update(long id, FacultyParam param);
        ApiResponse Update(List<FacultyParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(FacultyParam param);
        void ValidateParameters(List<FacultyParam> param);
    }
}
