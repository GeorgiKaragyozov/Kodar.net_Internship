using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Teacher;
using UniversityDemo.Business.Processor.Teacher;
using UniversityDemo.Data.Common;
using UniversityDemo.Presentation.Service.Teacher;

namespace UniversityDemoPresentation.Service.Teacher
{
    public class TeacherService: ITeacherService
    {
        public ITeacherProcessor Processor { get; set; }

        public TeacherService(ITeacherProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(TeacherParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<TeacherParam> param)
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

        public ApiResponse Update(long id, TeacherParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<TeacherParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(TeacherParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<TeacherParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
