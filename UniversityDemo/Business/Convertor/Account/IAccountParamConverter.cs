namespace UniversityDemo.Business.Convertor.Account
{
    public interface IAccountParamConverter
    {
        UniversityDemo.Account Convert(AccountParam param);

        UniversityDemo.Account Convert(AccountParam param, UniversityDemo.Account oldEntity);
    }
}
