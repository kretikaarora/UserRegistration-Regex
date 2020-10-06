using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        public void CheckNameValidation(string name)
        {
            string pattern = @"^[A-Z]{1}[a-zA-Z]{2,15}$";
            bool check = Regex.IsMatch(name, pattern);
            if (check == true)
                Console.WriteLine("the name entered is valid");
            else
                Console.WriteLine(" the name entered is not valid");
        }


    }
}
