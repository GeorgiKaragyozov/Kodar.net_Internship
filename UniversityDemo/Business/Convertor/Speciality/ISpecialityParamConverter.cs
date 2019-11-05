namespace UniversityDemo.Business.Convertor.Speciality
{
    public interface ISpecialityParamConverter
    {
        Model.Speciality Convert(SpecialityParam param, Model.Speciality oldEntity);
    }
}
