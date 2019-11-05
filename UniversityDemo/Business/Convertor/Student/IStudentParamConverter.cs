namespace UniversityDemo.Business.Convertor.Student
{
    public interface IStudentParamConverter
    {
        Model.Student Convert(StudentParam param, Model.Student oldEntity);
    }
}
