namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public interface IDisciplineStatusParamConverter
    {
        UniversityDemo.DisciplineStatus Convert(DisciplineStatusParam param);

        UniversityDemo.DisciplineStatus Convert(DisciplineStatusParam param,
         UniversityDemo.DisciplineStatus oldEntity);
    }
}
