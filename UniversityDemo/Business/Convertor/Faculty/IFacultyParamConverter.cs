namespace UniversityDemo.Business.Convertor.Faculty
{
    public interface IFacultyParamConverter
    {
        UniversityDemo.Faculty Convert(FacultyParam param);

        UniversityDemo.Faculty Convert(FacultyParam param,
         UniversityDemo.Faculty oldEntity);
    }
}
