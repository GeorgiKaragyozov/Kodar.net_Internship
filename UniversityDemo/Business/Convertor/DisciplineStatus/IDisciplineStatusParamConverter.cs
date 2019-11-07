using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public interface IDisciplineStatusParamConverter
    {
        Model.DisciplineStatus Convert(DisciplineStatusParam param, Model.DisciplineStatus oldEntity);
    }
}
