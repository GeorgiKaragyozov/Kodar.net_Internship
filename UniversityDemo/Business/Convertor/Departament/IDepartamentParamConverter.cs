using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Departament
{
    public interface IDepartamentParamConverter
    {
        Model.Departament Convert(DepartamentParam param, Model.Departament oldEntity);
    }
}
