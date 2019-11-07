using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public interface ITeacherStatusParamConverter
    {
        Model.TeacherStatus Convert(TeacherStatusParam param, Model.TeacherStatus oldEntity);
    }
}
