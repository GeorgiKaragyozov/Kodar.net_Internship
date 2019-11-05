namespace UniversityDemo.Business.Convertor.User
{
    public class UserParam : BaseParamNamed
    {
        private string _username;

        private string _password;

        public string Username
        {
            get { return this._username; }
            set
            {
                this._username = value;
            }
        }

        public string Password
        {
            get { return this._password; }
            set
            {

                this._password = value;
            }
        }

        public long StatusId { get; set; }
    }
}

