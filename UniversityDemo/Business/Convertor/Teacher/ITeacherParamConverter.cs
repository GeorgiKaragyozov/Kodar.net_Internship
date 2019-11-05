namespace UniversityDemo.Business.Convertor.Teacher
{
    public interface ITeacherParamConverter
    { 
        Model.Teacher Convert(TeacherParam param, Model.Teacher oldEntity);
    }
}
