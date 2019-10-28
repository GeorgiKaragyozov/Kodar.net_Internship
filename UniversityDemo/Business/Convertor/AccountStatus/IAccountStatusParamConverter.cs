namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public interface IAccountStatusParamConverter
    {
        UniversityDemo.AccountStatus Convert(AccountStatusParam param);

        UniversityDemo.AccountStatus Convert(AccountStatusParam param, UniversityDemo.AccountStatus oldEntity);
    }
}
