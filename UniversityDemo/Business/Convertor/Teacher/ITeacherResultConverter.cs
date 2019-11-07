using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public interface ITeacherResultConverter
    {
        TeacherResult Convert(Model.Teacher param);
    }
}
