using System;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusParamConverter: ISpecialityStatusParamConverter
    {
        public SpecialityStatusDao SpecialityStatusDao { get; set; }
    }
}
