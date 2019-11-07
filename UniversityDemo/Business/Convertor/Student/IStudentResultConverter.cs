using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Student
{
    public interface IStudentResultConverter
    {
        StudentResult Convert(Model.Student param);
    }
}
