using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Departament
{
    public interface IDepartamentResultConverter
    {
        DepartamentResult Convert(Model.Departament param);
    }
}
