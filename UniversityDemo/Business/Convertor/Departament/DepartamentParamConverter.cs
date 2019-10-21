using System;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentParamConverter: IDepartamentParamConverter
    {
        public IDepartamentDao Dao { get; set; }

        public DepartamentParamConverter(IDepartamentDao dao)
        {
            this.Dao = dao;
        }

        public UniversityDemo.Departament Convert(DepartamentParam param)
        {
            throw new NotImplementedException();
        }
    }
}
