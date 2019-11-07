using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public interface IDepartamentStatusParamConverter
    {
        Model.DepartamentStatus Convert(DepartamentStatusParam param, Model.DepartamentStatus oldEntity);
    }
}
