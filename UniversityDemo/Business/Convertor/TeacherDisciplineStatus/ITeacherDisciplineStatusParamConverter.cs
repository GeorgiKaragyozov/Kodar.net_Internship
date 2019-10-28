namespace UniversityDemo.Business.Convertor.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusParamConverter
    {
        Data.Entity.Model.Status.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param);

        Data.Entity.Model.Status.TeacherDisciplineStatus Convert(TeacherDisciplineStatusParam param,
          Data.Entity.Model.Status.TeacherDisciplineStatus oldEntity);
    }
}
