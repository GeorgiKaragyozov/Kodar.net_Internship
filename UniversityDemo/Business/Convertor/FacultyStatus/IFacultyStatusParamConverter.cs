namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public interface IFacultyStatusParamConverter
    {
        UniversityDemo.FacultyStatus Convert(FacultyStatusParam param);

        UniversityDemo.FacultyStatus Convert(FacultyStatusParam param,
        UniversityDemo.FacultyStatus oldEntity);
    }
}
