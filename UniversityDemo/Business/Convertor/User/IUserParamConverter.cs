namespace UniversityDemo.Business.Convertor.User
{
    public interface IUserParamConverter
    {
        UniversityDemo.User Convert(UserParam param);

        UniversityDemo.User Convert(UserParam param,
          UniversityDemo.User oldEntity);
    }
}
