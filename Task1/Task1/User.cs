using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string gender;
        public string email;
        private string password;
        public string status;

        public string Email 
        {
            set 
            {
                ValidateEmail(value);
                email = value;
            }
            get
            {
                return email;
            } 
        }
        public string Password
        {
            private set
            {
                if(value.Length < 10 || value.Length > 50)
                {
                    throw new Exception("Not correct password");
                }
                password = value;
            }
            get
            {
                return password;
            }
        }
        public int Id
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wrong id");
                }
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string FirstName
        {

            set
            {
                if (value.Length > 30 ||
                    value == "" ||
                    value[0].ToString() != value[0].ToString().ToUpper())
                {
                    throw new Exception("Not correct First Name");
                }
                firstName = value;
            }

            get
            {
                return firstName;
            }
        }
        public string LastName
        {

            set
            {
                if (value.Length > 30 ||
                    value == "" ||
                    value[0].ToString() != value[0].ToString().ToUpper())
                {
                    throw new Exception("Not correct Last Name");
                }
                lastName = value;
            }

            get
            {
                return lastName;
            }
        }
        public string Gender
        {

            set
            {
                if (value != "Male" && value != "Female" && value != "male" && value != "female")
                {
                    throw new Exception("Not correct Gender");
                }
                gender = value;
            }

            get
            {
                return gender;
            }
        }
        public DateTime DateOfBirth
        {
            set
            {
                if (value.AddYears(120) < DateTime.Now)
                {
                    throw new Exception("Not correct date of birth");
                }
                dateOfBirth = value;
            }

            get
            {
                return dateOfBirth;
            }
        }

        public User()
        {

        }
        public User(
            int id,
            string firstName,
            string lastName,
            string gender,
            string email,
            string password,
            DateTime dateOfBirth,
            string status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            this.email = email;
            this.password = password;
            DateOfBirth = dateOfBirth;
            this.status = status;
        }

        public User(
            int id,
            string firstName,
            string lastName,
            string gender,
            string email,
            string password):this(
                id, 
                firstName, 
                lastName, 
                gender, 
                email, 
                password, 
                DateTime.Now, 
                "Active")
        {
        }

        public User(
            int id,
            string firstName,
            string lastName,
            string gender,
            string email,
            string password,
            DateTime dateOfBirth)
        {
            this.status = "Active";
        }

        public void ChangePassword(string newPassword)
        {
            if (status != "Active")
            {
                throw new Exception("Can't change password because of wrong unactive status");
            }
            Password = newPassword;
        }

        public string GetShortInfo()
        {
            return $"" +
                $"FirstName - {FirstName}\n" +
                $"LastName - {LastName}\n" +
                $"email - {email}\n";
        }

        public string GetAllInfo()
        {
            return $"" +
                $"id - {Id}\n" +
                $"FirstName - {FirstName}\n" +
                $"LastName - {LastName}\n" +
                $"DateOfBirth - {DateOfBirth}\n" +
                $"Gender - {Gender}\n" +
                $"email - {email}\n" +
                $"Password - {Password}\n" +
                $"status - {status}\n";
        }

        private void ValidateEmail(string email)
        {
            if (!email.Contains('@') || (email.Length < 10 || email.Length>100))
            {
                throw new Exception("Please write email with @");
            }
            var aCharIndex = email.IndexOf('@');
            var domain = email.Substring(++aCharIndex, email.Length);
            if (!domain.Contains('.'))
            {
                throw new Exception("Please write email with .");
            }
            var domainParts = domain.Split('.');
            if(domainParts.Length != 2)
            {
                throw new Exception("Incorrect domain name should be like (...@gmail.com)");
            }
        }
        
    } 
}