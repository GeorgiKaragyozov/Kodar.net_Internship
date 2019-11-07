using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public interface ITeacherDisciplineResultConverter
    {
        TeacherDisciplineResult Convert(Model.TeacherDiscipline param);
    }
}
