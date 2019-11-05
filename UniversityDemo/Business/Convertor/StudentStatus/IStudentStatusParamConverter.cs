namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public interface IStudentStatusParamConverter
    {
        Model.StudentStatus Convert(StudentStatusParam param, Model.StudentStatus oldEntity);
    }
}
