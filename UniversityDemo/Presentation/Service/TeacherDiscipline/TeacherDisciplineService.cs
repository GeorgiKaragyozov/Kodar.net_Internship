using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDiscipline;
using UniversityDemo.Business.Processor.TeacherDiscipline;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.TeacherDiscipline
{
    public class TeacherDisciplineService: ITeacherDisciplineService
    {
        public TeacherDisciplineProcessor Processor { get; set; }

        public ApiResponse Create(TeacherDisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<TeacherDisciplineParam> param)
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

        public ApiResponse Update(long id, TeacherDisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<TeacherDisciplineParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(TeacherDisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<TeacherDisciplineParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
