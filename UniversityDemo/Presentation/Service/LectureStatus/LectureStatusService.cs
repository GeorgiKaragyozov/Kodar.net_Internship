using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.LectureStatus;
using UniversityDemo.Business.Processor.LectureStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.LectureStatus
{
    public class LectureStatusService: ILectureStatusService
    {
        public ILectureStatusProcessor Processor { get; set; }

        public LectureStatusService(ILectureStatusProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(LectureStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<LectureStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPk(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, LectureStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<LectureStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(LectureStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<LectureStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
