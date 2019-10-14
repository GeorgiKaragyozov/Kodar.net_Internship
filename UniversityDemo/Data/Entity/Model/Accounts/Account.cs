using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using UniversityDemo.Enums;

namespace UniversityDemo
{
    //[DataContract]
    public abstract class Account: NamedPersistent
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

        //[DefaultValue("Male/Female")]
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public Gender GenderType { get; set; }

        //// included in JSON
        //[DataMember]
        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("The first name can't be empty .");
                }

                this._firstName = value;
            }
        }
              
        public string MiddleName
        {
            get { return this._middleName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("The middle name can't be empty .");
                }

                this._middleName = value;
            }
        }

        public string LastName
        {
            get { return this._lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("The last name can't be empty .");
                }

                this._lastName = value;
            }
        }

        public string FullName
        {
            get { return FirstName + " " + MiddleName + " " + LastName;}
        }

        public string Egn
        {
            get
            { return this._egn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Please fill in the column egn !");
                }
                else if (value.Length <= 0 && value.Length > 15)
                {
                    throw new Exception("The EGN is not valid !");
                }

                this._egn = value;
            }
        }

        public string Address
        {
            get
            { return this._address; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Plase enter the address");
                }

                this._address = value;
            }
        }

        public string City
        {
            get
            { return this._city; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Plase enter the City");
                }

                this._city = value;
            }
        }

        public string Country
        {
            get
            { return this._country; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Plase enter the Country");
                }

                this._country = value;
            }
        }

        public string MobilePhone
        {
            get
            { return this._mobilePhone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Please enter the mobile phone " +
                        "number.");
                }
                else if (value.Length <= 0)
                {
                    throw new Exception("Mobile phone number is not valid !");
                }

                this._mobilePhone = value;

            }
        }

        public string HomePhone
        {
            get { return this._homePhone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Please enter the home phone " +
                        "number.");
                }
                else if (value.Length <= 0)
                {
                    throw new Exception("Home phone number is not valid !");
                }

                this._homePhone = value;
            }
        }

        public string Email
        {
            get { return this._email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Please enter an email.");
                }

                this._email = value;
            }
        }

        public User User { get; set; }

        public AccountStatus AccountStatus { get; set; }
    }
}

