namespace UniversityDemo.Business.Convertor.DepartamentStatus
{
    public interface IDepartamentStatusParamConverter
    {
        UniversityDemo.DepartamentStatus Convert(DepartamentStatusParam param);

        UniversityDemo.DepartamentStatus Convert(DepartamentStatusParam param,
            UniversityDemo.DepartamentStatus oldEntity);
    }
}
