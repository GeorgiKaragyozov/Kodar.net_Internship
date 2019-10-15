using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public class SpecialityParamConverter: ISpecialityParamConverter
    {
        public SpecialityDao SpecialityDao { get; set; }

        public UniversityDemo.Speciality Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
