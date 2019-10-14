using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Lecture;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Lecture
{
    public interface ILectureService
    {
        ApiResponse FindByPk(long id);
        ApiResponse ListAll();

        ApiResponse Create(LectureParam param);
        ApiResponse Create(List<LectureParam> param);

        ApiResponse Update(long id, LectureParam param);
        ApiResponse Update(List<LectureParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(LectureParam param);
        void ValidateParameters(List<LectureParam> param);
    }
}
