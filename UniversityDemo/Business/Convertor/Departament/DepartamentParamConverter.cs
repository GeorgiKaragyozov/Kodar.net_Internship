using System;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentParamConverter: IDepartamentParamConverter
    {
        public DepartamentDao DepartamentDao { get; set; }
    }
}
