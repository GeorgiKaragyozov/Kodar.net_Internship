namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public interface ISpecialityStatusParamConverter
    {
        Model.SpecialityStatus Convert(SpecialityStatusParam param, Model.SpecialityStatus oldEntity);
    }
}
