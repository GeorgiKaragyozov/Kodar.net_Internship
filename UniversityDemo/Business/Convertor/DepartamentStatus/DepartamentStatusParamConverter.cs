using System;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusParamConverter: IDepartamentStatusParamConverter
    {
        public DepartamentStatusDao Dao { get; set; }

        public UniversityDemo.DepartamentStatus Convert(DepartamentStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
