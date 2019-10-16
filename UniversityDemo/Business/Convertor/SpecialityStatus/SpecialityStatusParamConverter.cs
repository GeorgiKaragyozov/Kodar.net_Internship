using System;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusParamConverter: ISpecialityStatusParamConverter
    {
        public SpecialityStatusDao Dao { get; set; }

        public UniversityDemo.SpecialityStatus Convert(SpecialityStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
