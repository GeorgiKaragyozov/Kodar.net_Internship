using System;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParamConverter: ISpecialityParamConverter
    {
        public SpecialityDao Dao { get; set; }

        public UniversityDemo.Speciality Convert(SpecialityParam param)
        {
            throw new NotImplementedException();
        }
    }
}
