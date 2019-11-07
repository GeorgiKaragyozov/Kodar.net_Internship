using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public interface IDisciplineResultConverter
    {
        DisciplineResult Convert(Model.Discipline param);
    }
}
