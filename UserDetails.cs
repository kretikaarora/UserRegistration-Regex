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
                if (firstName == " ")
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
        public void LastNameDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your last name");
                string lastName = Console.ReadLine();
                if (lastName == " ")
                {
                    Console.WriteLine("no  value entered");
                    Console.WriteLine("please enter some value");
                }
                bool check = userValidation.CheckNameValidation(lastName);
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
        public void EmailDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your email");
                string email = Console.ReadLine();
                if (email == " ")
                {
                    Console.WriteLine("no  value entered");
                    Console.WriteLine("please enter some value");
                }
                bool check = userValidation.CheckNameValidation(email);
                if (check == true)
                {
                    Console.WriteLine("the email entered is valid");
                    break;

                }
                else
                {
                    Console.WriteLine("the email entered is not valid");
                    Console.WriteLine("enter a valid email ! ");
                }

            }


        }

    }
}