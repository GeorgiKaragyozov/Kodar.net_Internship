namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public interface ISpecialityStatusParamConverter
    {
        UniversityDemo.SpecialityStatus Convert(SpecialityStatusParam param);

        UniversityDemo.SpecialityStatus Convert(SpecialityStatusParam param,
           UniversityDemo.SpecialityStatus oldEntity);
    }
}
