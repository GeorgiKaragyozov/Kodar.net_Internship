using System;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParamConverter: ISpecialityParamConverter
    {
        public SpecialityDao SpecialityDao { get; set; }
    }
}
