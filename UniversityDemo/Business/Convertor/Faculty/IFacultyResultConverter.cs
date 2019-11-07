using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public interface IFacultyResultConverter
    {
        FacultyResult Convert(Model.Faculty param);
    }
}
