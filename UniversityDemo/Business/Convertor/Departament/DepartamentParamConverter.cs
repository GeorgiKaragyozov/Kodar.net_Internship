using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentParamConverter: IDepartamentParamConverter
    {
        public DepartamentDao DepartamentDao { get; set; }

        public UniversityDemo.Departament Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
