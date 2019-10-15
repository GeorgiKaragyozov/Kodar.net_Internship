using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DisciplineStatus;
using UniversityDemo.Business.Processor.DisciplineStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.DisciplineStatus
{
    public class DisciplineStatusService: IDisciplineStatusService
    {
        public DisciplineStatusProcessor Processor { get; set; }

        public ApiResponse Create(DisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<DisciplineStatusParam> param)
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

        public ApiResponse Update(long id, DisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<DisciplineStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(DisciplineStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<DisciplineStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
