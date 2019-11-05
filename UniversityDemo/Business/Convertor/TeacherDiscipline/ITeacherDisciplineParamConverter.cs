namespace UniversityDemo.Business.Convertor.TeacherDiscipline
{
    public interface ITeacherDisciplineParamConverter
    {
        Model.TeacherDiscipline Convert(TeacherDisciplineParam param, Model.TeacherDiscipline oldEntity);
    }
}
