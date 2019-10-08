using System;
using UniversityDemo.Business.Convertor.SpecialityStatus;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Processor.SpecialityStatus
{
    public class SpecialityStatusProcessor: ISpecialityStatusProcessor
    {
        public SpecialityStatusDao SpecialityStatusDao { get; set; }

        public SpecialityStatusParamConverter SpecialityStatusParamConverter { get; set; }

        public SpecialityStatusResultConverter SpecialityStatusResultConverter { get; set; }
    }
}
