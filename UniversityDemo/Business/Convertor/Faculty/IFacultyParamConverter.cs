using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public interface IFacultyParamConverter
    {
        Model.Faculty Convert(FacultyParam param, Model.Faculty oldEntity);
    }
}
