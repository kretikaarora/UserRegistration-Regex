using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class UsersDetails
    {
        UserValidation userValidation = new UserValidation();

        public void FirstNameDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your first name");
                string firstName = Console.ReadLine();
                if (firstName ==" ")
                {
                    Console.WriteLine("no  value entered");
                    Console.WriteLine("please enter some value");
                }
                bool check = userValidation.CheckNameValidation(firstName);
                if (check == true)
                {
                    Console.WriteLine("the name entered is valid");
                    break;

                }
                else
                {
                    Console.WriteLine("the name entered is not valid");
                    Console.WriteLine("enter a valid name ! ");
                }

            }
            

        }
    }
}
