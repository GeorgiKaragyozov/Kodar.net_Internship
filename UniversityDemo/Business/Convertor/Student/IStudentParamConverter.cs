namespace UniversityDemo.Business.Convertor.Student
{
    public interface IStudentParamConverter
    {
        UniversityDemo.Student Convert(StudentParam param);

        UniversityDemo.Student Convert(StudentParam param,
          UniversityDemo.Student oldEntity);
    }
}
