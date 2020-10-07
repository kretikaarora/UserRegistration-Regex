using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
                bool check = userValidation.CheckEmailValidation(email);
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
        public void PhoneDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your phone number");
                string phoneNumber = Console.ReadLine();

                if (phoneNumber == " ")
                {
                    Console.WriteLine("no value entered");
                    Console.WriteLine("please enter some value");
                }
                bool check = userValidation.CheckPhoneNumber(phoneNumber);
                if (check == true)
                {
                    Console.WriteLine("the phone number  entered is valid");
                    break;

                }
                else
                {
                    Console.WriteLine("the phone number entered is not valid");
                    Console.WriteLine("enter a valid phone number ! ");
                }

            }


        }
        public void Password()
        {
            while (true)
            {
                Console.WriteLine("please enter your password ");
                string password = Console.ReadLine();

                if (password==" ")
                {
                    Console.WriteLine("no value entered");
                    Console.WriteLine("please enter some value");
                }

                bool check = userValidation.CheckPassword(password);
                if (check == true)
                {
                    Console.WriteLine("the password entered is valid");
                    break;

                }
                else
                {
                    Console.WriteLine("the password entered is not valid");
                    Console.WriteLine("enter a valid password  ! ");
                }

            }


        }


    }
}
