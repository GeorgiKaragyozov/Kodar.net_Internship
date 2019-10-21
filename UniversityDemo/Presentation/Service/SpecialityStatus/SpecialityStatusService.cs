using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.SpecialityStatus;
using UniversityDemo.Business.Processor.SpecialityStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.SpecialityStatus
{
    public class SpecialityStatusService: ISpecialityStatusService
    {
        public ISpecialityStatusProcessor Processor { get; set; }

        public SpecialityStatusService(ISpecialityStatusProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(SpecialityStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<SpecialityStatusParam> param)
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

        public ApiResponse Update(long id, SpecialityStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<SpecialityStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(SpecialityStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<SpecialityStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
