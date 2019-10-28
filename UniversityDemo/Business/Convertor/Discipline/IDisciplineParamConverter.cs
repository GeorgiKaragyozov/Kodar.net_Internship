namespace UniversityDemo.Business.Convertor.Discipline
{
    public interface IDisciplineParamConverter
    {
        UniversityDemo.Discipline Convert(DisciplineParam param);

        UniversityDemo.Discipline Convert(DisciplineParam param,
            UniversityDemo.Discipline oldEntity);
    }
}
