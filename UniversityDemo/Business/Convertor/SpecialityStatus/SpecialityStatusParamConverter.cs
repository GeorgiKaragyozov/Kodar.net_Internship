using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusParamConverter: ISpecialityStatusParamConverter
    {
        public SpecialityStatusDao SpecialityStatusDao { get; set; }

        public UniversityDemo.SpecialityStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
