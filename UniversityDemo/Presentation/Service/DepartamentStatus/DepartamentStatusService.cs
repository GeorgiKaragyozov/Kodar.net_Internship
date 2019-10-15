using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DepartamentStatus;
using UniversityDemo.Business.Processor.DepartamentStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.DepartamentStatus
{
    public class DepartamentStatusService: IDepartamentStatusService
    {
        public DepartamentStatusProcessor Processor { get; set; }

        public ApiResponse Create(DepartamentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<DepartamentStatusParam> param)
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

        public ApiResponse Update(long id, DepartamentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<DepartamentStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(DepartamentStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<DepartamentStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
