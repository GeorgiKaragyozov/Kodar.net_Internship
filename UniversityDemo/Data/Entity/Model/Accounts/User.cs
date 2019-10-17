using System;

namespace UniversityDemo
{
    public class User: Persistent
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

        public UserStatus Status { get; set; }
    }
}
