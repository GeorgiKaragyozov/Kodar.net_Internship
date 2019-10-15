using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherStatus;
using UniversityDemo.Business.Processor.TeacherStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.TeacherStatus
{
    public class TeacherStatusService: ITeacherStatusService
    {
        public TeacherStatusProcessor Processor { get; set; }

        public ApiResponse Create(TeacherStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<TeacherStatusParam> param)
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

        public ApiResponse Update(long id, TeacherStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<TeacherStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(TeacherStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<TeacherStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
