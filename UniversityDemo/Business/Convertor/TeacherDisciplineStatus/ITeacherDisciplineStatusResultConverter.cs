using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusResultConverter
    {
        TeacherDisciplineStatusResult Convert(Model.TeacherDisciplineStatus param);
    }
}
