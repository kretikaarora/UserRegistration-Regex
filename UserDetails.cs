using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
                    Console.WriteLine("the name {0} is valid",firstName);
                    Console.WriteLine("successful entry");
                    break;

                }
                else
                {
                    Console.WriteLine("unsuccessful entry");
                    Console.WriteLine("the name {0} is not valid",firstName);
                    Console.WriteLine("enter a valid name with min three alphabets and first letter capital ");
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
                    Console.WriteLine("the name {0} is valid",lastName);
                    Console.WriteLine("successful entry");
                    break;

                }
                else
                {
                    Console.WriteLine("unsuccessful entry");
                    Console.WriteLine("the name {0} is not valid",lastName);
                    Console.WriteLine("enter a valid name with min three alphabets and first letter capital ");
                }

            }


        }
        public void EmailDetail()
        {

            
                string [] multipleEmailIdList = new string[10];
                
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine("please enter your email");
                    string variable = Console.ReadLine();
                     multipleEmailIdList[i]=variable;

                    bool check = userValidation.CheckEmailValidation(variable);
                    if (check == true)
                    {
                        Console.WriteLine("the email id {0} is valid", variable) ;
                        Console.WriteLine("successful entry");
                        

                    }
                    else
                    {
                        Console.WriteLine("unsuccessful entry");
                        Console.WriteLine("the email id {0} is not valid",variable);
                        Console.WriteLine(" enter an email id with proper format");
                    }
                    Console.WriteLine("Press N if you dont want enter another email address");
                    Console.WriteLine("Press any other aplphabet if you want to add  another email address");
                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == ('N'))
                {
                    break;
                }
                }
                Console.WriteLine("EmailDetails are -");
                foreach(string entry in multipleEmailIdList)
                {
                  Console.WriteLine(entry);
                }
        }
        public void PhoneDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your phone number");
                string phoneNumber = Console.ReadLine();
               
                bool check = userValidation.CheckPhoneNumber(phoneNumber);
                if (check == true)
                {
                    Console.WriteLine("the phone number  entered is valid");
                    Console.WriteLine("successful entry");
                    break;

                }
                else
                {
                    Console.WriteLine("unsuccessful entry");
                    Console.WriteLine("the phone number entered is not valid");
                    Console.WriteLine("enter a  phone number with a gap in between 10 digit number and pincode ");
                }

            }


        }
        public void Password()
        {
            while (true)
            {
                Console.WriteLine("please enter your password ");
                string password = Console.ReadLine();
                
                bool check = userValidation.CheckPassword(password);
                if (check == true)
                {
                    Console.WriteLine("the password {0} is valid",password);
                    Console.WriteLine("successful entry");
                    break;

                }
                else
                {
                    Console.WriteLine("unsuccessful entry");
                    Console.WriteLine("the password entered is not valid");
                    Console.WriteLine("enter a valid password with \n 1.atleast one capital letter \n 2.atleast one small letter");
                    Console.WriteLine(" 3.one special character \n 4.atleast one digit");
                }

            }


        }


    }
}
