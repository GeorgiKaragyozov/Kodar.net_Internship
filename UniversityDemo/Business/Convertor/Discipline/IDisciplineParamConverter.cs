namespace UniversityDemo.Business.Convertor.Discipline
{
    public interface IDisciplineParamConverter
    {
        Model.Discipline Convert(DisciplineParam param, Model.Discipline oldEntity);
    }
}
