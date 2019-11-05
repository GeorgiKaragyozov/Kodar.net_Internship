namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public interface IAccountStatusParamConverter
    {
        Model.AccountStatus Convert(AccountStatusParam param, Model.AccountStatus oldEntity);
    }
}
