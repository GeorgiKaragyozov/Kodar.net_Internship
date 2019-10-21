using System;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusParamConverter: IDepartamentStatusParamConverter
    {
        public IDepartamentStatusDao Dao { get; set; }

        public DepartamentStatusParamConverter(IDepartamentStatusDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.DepartamentStatus Convert(DepartamentStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
