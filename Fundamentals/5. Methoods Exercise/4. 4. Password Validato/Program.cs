using System;

namespace _4._4._Password_Validato
{
    class Program
    {
        static void Main(string[] args)
        {
            string Password = Console.ReadLine();

            bool isTrue = ValidateLenght(Password)&&
            VadidateLatersAndDigits(Password)&&
          Validate2Digits(Password);

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidateLenght(Password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!VadidateLatersAndDigits(Password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!Validate2Digits(Password))
                {
                    Console.WriteLine("Password must have at least 2 digits");

                }
            }
        }

        private static bool Validate2Digits(string password)
        {
            int count = 0;

            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count>=2)
            {
                return true;
            }

            return false;
        }

        private static bool VadidateLatersAndDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidateLenght(string password)
        {
            if (password.Length>=6&&password.Length<=10)
            {

                bool isTrue = true;
                return isTrue; 
                //return true;
            }

            
                return false;
            
        }
    }
}
