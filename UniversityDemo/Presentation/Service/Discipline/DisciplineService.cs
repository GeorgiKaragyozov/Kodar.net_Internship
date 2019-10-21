using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Discipline;
using UniversityDemo.Business.Processor.Discipline;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Discipline
{
    public class DisciplineService: IDisciplineService
    {
        public IDisciplineProcessor Processor { get; set; }

        public DisciplineService(IDisciplineProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(DisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<DisciplineParam> param)
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

        public ApiResponse Update(long id, DisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<DisciplineParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(DisciplineParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<DisciplineParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
