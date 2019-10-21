using System;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParamConverter: ISpecialityParamConverter
    {
        public ISpecialityDao Dao { get; set; }

        public SpecialityParamConverter(ISpecialityDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Speciality Convert(SpecialityParam param)
        {
            throw new NotImplementedException();
        }
    }
}
