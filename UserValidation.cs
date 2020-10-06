using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public bool CheckNameValidation(string name)
        {
            string pattern = @"^[A-Z]{1}[a-zA-Z]{2,15}$";

              return Regex.IsMatch(name, pattern);

            
        }

        public bool CheckEmailValidation(string email)
        {
            string pattern = @"[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
