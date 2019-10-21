using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Faculty;
using UniversityDemo.Business.Processor.Faculty;
using UniversityDemo.Data.Common;

namespace UniversityDemo.Presentation.Service.Faculty
{
    public class FacultyService: IFacultyService
    {
        public IFacultyProcessor Processor { get; set; }

        public FacultyService(IFacultyProcessor processor)
        {
            this.Processor = processor;
        }

        public ApiResponse Create(FacultyParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<FacultyParam> param)
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

        public ApiResponse Update(long id, FacultyParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<FacultyParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(FacultyParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<FacultyParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
