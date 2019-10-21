using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Student;
using UniversityDemo.Business.Processor.Student;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Student
{
    public class StudentService: IStudentService
    {
        public IStudentProcessor Processor { get; set; }

        public StudentService(IStudentProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(StudentParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<StudentParam> param)
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

        public ApiResponse Update(long id, StudentParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<StudentParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(StudentParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<StudentParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
