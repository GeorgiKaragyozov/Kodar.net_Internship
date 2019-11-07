using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusParamConverter
    {
        Model.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param,
          Model.TeacherDisciplineStatus oldEntity);
    }
}
