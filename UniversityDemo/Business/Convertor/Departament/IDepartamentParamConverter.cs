namespace UniversityDemo.Business.Convertor.Departament
{
    public interface IDepartamentParamConverter
    {
        UniversityDemo.Departament Convert(DepartamentParam param);

        UniversityDemo.Departament Convert(DepartamentParam param, UniversityDemo.Departament oldEntity);
    }
}
