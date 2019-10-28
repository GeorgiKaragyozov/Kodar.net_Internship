using System;

namespace UniversityDemo.Business.Convertor.User
{
    public class UserResult : BaseResultNamed
    {

        private string _username;

        private string _password;

        public string Username
        {
            get { return this._username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please enter your username .");
                }

                this._username = value;
            }
        }

        public string Password
        {
            get { return this._password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please enter password .");
                }

                this._password = value;
            }
        }

        public UniversityDemo.UserStatus Status { get; set; }
    }
}
