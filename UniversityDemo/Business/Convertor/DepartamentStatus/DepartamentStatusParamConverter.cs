using System;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public class DepartamentStatusParamConverter: IDepartamentStatusParamConverter
    {
        public DepartamentStatusDao DepartamentStatusDao { get; set; }
    }
}
