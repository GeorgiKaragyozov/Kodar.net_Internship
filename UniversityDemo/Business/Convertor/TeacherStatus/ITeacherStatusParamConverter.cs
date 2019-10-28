namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public interface ITeacherStatusParamConverter
    {
        Model.Accounts.TeacherStatus Convert(TeacherStatusParam param);

        Model.Accounts.TeacherStatus Convert(TeacherStatusParam param,
          Model.Accounts.TeacherStatus oldEntity);
    }
}
