using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Speciality;
using UniversityDemo.Business.Processor.Speciality;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Speciality
{
    public class SpecialityService: ISpecialityService
    {
        public ISpecialityProcessor Processor { get; set; }

        public SpecialityService(ISpecialityProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(SpecialityParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<SpecialityParam> param)
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

        public ApiResponse Update(long id, SpecialityParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<SpecialityParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(SpecialityParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<SpecialityParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
