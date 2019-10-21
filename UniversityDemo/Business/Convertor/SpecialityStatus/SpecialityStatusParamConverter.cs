using System;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public class SpecialityStatusParamConverter: ISpecialityStatusParamConverter
    {
        public ISpecialityStatusDao Dao { get; set; }

        public SpecialityStatusParamConverter(ISpecialityStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.SpecialityStatus Convert(SpecialityStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
