namespace UniversityDemo.Business.Convertor.Account
{
    public interface IAccountParamConverter 
    {
        Model.Account Convert(AccountParam param, Model.Account oldEntity);
    }
}
