using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public interface IFacultyStatusParamConverter
    {
        Model.FacultyStatus Convert(FacultyStatusParam param, Model.FacultyStatus oldEntity);
    }
}
