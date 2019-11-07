using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public interface IStudentStatusResultConverter
    {
        StudentStatusResult Convert(Model.StudentStatus param);
    }
}
