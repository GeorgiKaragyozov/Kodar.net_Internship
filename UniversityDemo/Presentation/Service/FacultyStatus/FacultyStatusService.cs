using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.FacultyStatus;
using UniversityDemo.Business.Processor.FacultyStatus;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.FacultyStatus
{
    public class FacultyStatusService: IFacultyStatusService
    {
        public FacultyStatusProcessor Processor { get; set; }

        public ApiResponse Create(FacultyStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<FacultyStatusParam> param)
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

        public ApiResponse Update(long id, FacultyStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<FacultyStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(FacultyStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<FacultyStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
