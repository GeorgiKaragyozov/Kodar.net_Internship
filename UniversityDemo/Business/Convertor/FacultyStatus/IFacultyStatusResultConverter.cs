using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public interface IFacultyStatusResultConverter
    {
        FacultyStatusResult Convert(Model.FacultyStatus param);
    }
}
