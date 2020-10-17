using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        public bool CheckNameValidation(string name)
        {
            if(name.Equals(string.Empty))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "name should not empty");
            }
            try
            { // Comparing namePattern to input given by user
              // Capital first name and min 3 letters 
                string namePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
                return Regex.IsMatch(name, namePattern);
            }
            catch(NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Name should not null");
            }
         
        }

        public bool CheckEmailValidation(string email)
        {
            if (email.Equals(string.Empty))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "eamil should not empty");
            }
            try
            {
                string pattern = @"^([a-z0-9A-Z])+([._+-]?[a-z0-9A-Z]+)*[@]{1}[a-z0-9A-Z]+[.]{1}[a-zA-Z]{2,}([.]{1}[a-z]{2,})?$";
                return Regex.IsMatch(email, pattern);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Name should not null");
            }

        }
        public bool CheckPhoneNumber(string phoneNo)
        {
            if (phoneNo.Equals(string.Empty))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "phone number should not empty");
            }
            try
            {
                string pattern = @"^[1-9]{2}[ ]{1}[0-9]{10}$";
                return Regex.IsMatch(phoneNo, pattern);

            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Name should not null");
            }

        }
        public bool CheckPassword(String password)
        {
            if (password.Equals(string.Empty))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "password should not empty");
            }
            try
            {
                // string pattern = @"^(?=.{8,}$)(?=.*[A-Z])(?=.*[@#$%^&*])";
                string pattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
                return Regex.IsMatch(password, pattern);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Name should not null");
            }

        }

    }
}
