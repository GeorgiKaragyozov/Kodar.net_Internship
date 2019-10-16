namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public interface ITeacherStatusParamConverter
    {
        Model.Accounts.TeacherStatus Convert(TeacherStatusParam param);
    }
}
