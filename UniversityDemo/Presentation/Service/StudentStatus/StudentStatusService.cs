using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.StudentStatus;
using UniversityDemo.Business.Processor.StudentStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.StudentStatus
{
    public class StudentStatusService: IStudentStatusService
    {
        public StudentStatusProcessor Processor { get; set; }

        public ApiResponse Create(StudentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<StudentStatusParam> param)
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

        public ApiResponse Update(long id, StudentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<StudentStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(StudentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<StudentStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
