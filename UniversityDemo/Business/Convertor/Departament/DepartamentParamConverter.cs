using System;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentParamConverter: IDepartamentParamConverter
    {
        public DepartamentDao Dao { get; set; }

        public UniversityDemo.Departament Convert(DepartamentParam param)
        {
            throw new NotImplementedException();
        }
    }
}
