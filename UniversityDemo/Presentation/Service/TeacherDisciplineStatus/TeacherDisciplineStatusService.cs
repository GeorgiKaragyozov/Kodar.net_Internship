using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDisciplineStatus;
using UniversityDemo.Business.Processor.TeacherDisciplineStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusService: ITeacherDisciplineStatusService
    {
        public TeacherDisciplineStatusProcessor Processor { get; set; }

        public ApiResponse Create(TeacherDisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<TeacherDisciplineStatusParam> param)
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

        public ApiResponse Update(long id, TeacherDisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<TeacherDisciplineStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(TeacherDisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<TeacherDisciplineStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
