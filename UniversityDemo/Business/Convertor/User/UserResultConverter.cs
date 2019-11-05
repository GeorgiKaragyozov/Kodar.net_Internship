namespace UniversityDemo.Business.Convertor.User
{
    public class UserResultConverter : IUserResultConverter
    {
        public UserResult Convert(Model.User param)
        {
            UserResult result = new UserResult()
            {
                Id = param.Id,
                Username = param.Username,
                Password = param.Password,

                StatusId = param.Status.Id,
                StatusName = param.Status.Name             
            };

            return result;
        }
    }
}
