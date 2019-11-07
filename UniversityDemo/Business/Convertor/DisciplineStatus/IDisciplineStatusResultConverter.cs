using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public interface IDisciplineStatusResultConverter
    {
        DisciplineStatusResult Convert(Model.DisciplineStatus param);
    }
}
