using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Departament;
using UniversityDemo.Business.Processor.Departament;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Departament
{
    public class DepartamentService: IDepartamentService
    {
        public IDepartamentProcessor Processor { get; set; }

        public DepartamentService(IDepartamentProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(DepartamentParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<DepartamentParam> param)
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

        public ApiResponse Update(long id, DepartamentParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<DepartamentParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(DepartamentParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<DepartamentParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
