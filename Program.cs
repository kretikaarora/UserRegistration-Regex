using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to User Registration");
            Console.WriteLine("please enter your name");
            string firstName = Console.ReadLine();
            UserValidation userValidation = new UserValidation();
            userValidation.CheckNameValidation(firstName);





        }
    }
}
