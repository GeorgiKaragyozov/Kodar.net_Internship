using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.LectureStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.LectureStatus
{
    public interface ILectureStatusService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(LectureStatusParam param);
        ApiResponse Create(List<LectureStatusParam> param);

        ApiResponse Update(long id, LectureStatusParam param);
        ApiResponse Update(List<LectureStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(LectureStatusParam param);
        void ValidateParameters(List<LectureStatusParam> param);
    }
}
