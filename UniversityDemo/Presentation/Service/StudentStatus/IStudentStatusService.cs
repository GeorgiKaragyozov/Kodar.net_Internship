using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.StudentStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.StudentStatus
{
    public interface IStudentStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(StudentStatusParam param);
        ApiResponse Create(List<StudentStatusParam> param);

        ApiResponse Update(long id, StudentStatusParam param);
        ApiResponse Update(List<StudentStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(StudentStatusParam param);
        void ValidateParameters(List<StudentStatusParam> param);
    }
}
