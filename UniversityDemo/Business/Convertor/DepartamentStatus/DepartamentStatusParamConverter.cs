using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusParamConverter: IDepartamentStatusParamConverter
    {
        public DepartamentStatusDao DepartamentStatusDao { get; set; }

        public UniversityDemo.DepartamentStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
