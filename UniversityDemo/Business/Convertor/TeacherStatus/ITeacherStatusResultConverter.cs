using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public interface ITeacherStatusResultConverter
    {
        TeacherStatusResult Convert(Model.TeacherStatus param);
    }
}
