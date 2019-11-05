using System;
using UniversityDemo.Enums;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountParam : BaseParamNamed
    {
        private string _firstName;

        private string _middleName;

        private string _lastName;

        private string _egn;

        private string _address;

        private string _city;

        private string _country;

        private string _mobilePhone;

        private string _homePhone;

        private string _email;

        public Gender GenderType { get; set; }

        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                this._firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this._middleName; }
            set
            {
                this._middleName = value;
            }
        }

        public string LastName
        {
            get { return this._lastName; }
            set
            {
                this._lastName = value;
            }
        }

        public string Egn
        {
            get
            { return this._egn; }
            set
            {
                this._egn = value;
            }
        }

        public string Address
        {
            get
            { return this._address; }
            set
            {
                this._address = value;
            }
        }

        public string City
        {
            get
            { return this._city; }
            set
            {
                this._city = value;
            }
        }

        public string Country
        {
            get
            { return this._country; }
            set
            {
                this._country = value;
            }
        }

        public string MobilePhone
        {
            get
            { return this._mobilePhone; }
            set
            {

                this._mobilePhone = value;
            }
        }

        public string HomePhone
        {
            get { return this._homePhone; }
            set
            {
                this._homePhone = value;
            }
        }

        public string Email
        {
            get { return this._email; }
            set
            {
                this._email = value;
            }
        }

        public long UserId { get; set; }

        public long StatusId { get; set; }
    }
}
