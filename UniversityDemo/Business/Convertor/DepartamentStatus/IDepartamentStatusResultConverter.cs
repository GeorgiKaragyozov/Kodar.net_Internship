using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public interface IDepartamentStatusResultConverter
    {
        DepartamentStatusResult Convert(Model.DepartamentStatus param);
    }
}
