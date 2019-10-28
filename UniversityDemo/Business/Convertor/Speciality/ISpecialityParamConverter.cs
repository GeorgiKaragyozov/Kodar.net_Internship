namespace UniversityDemo.Business.Convertor.Speciality
{
    public interface ISpecialityParamConverter
    {
        UniversityDemo.Speciality Convert(SpecialityParam param);

        UniversityDemo.Speciality Convert(SpecialityParam param,
           UniversityDemo.Speciality oldEntity);
    }
}
