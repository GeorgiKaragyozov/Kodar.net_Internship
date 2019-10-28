namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public interface IStudentStatusParamConverter
    {
        UniversityDemo.StudentStatus Convert(StudentStatusParam param);

        UniversityDemo.StudentStatus Convert(StudentStatusParam param,
          UniversityDemo.StudentStatus oldEntity);
    }
}
