using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    internal class Handling
    {
        public static void VotingAbility(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new AgeInvalidException("Invalid age for voting");
                }
                Console.WriteLine("valid age for voting");
            }
            catch (AgeInvalidException e)
            {
                Console.WriteLine("Except: "+e.ToString());
            }

        }

        public static void Calculate(double num)
        {
            try
            {
                if (num <= 0)
                {
                    throw new NonZeroException("Number Should be greater than 0");
                }
                double result = Math.Sqrt(num);
                Console.WriteLine(result);
            }
            catch (NonZeroException e)
            {
                Console.WriteLine("Except: "+e.ToString());
            }
        }

        public static void PasswordCheck(string password)
        {
            try
            {
                if(password.Length <= 3)
                {
                    throw new InvalidPasswordException("Password not correct need some more characters");
                }
                Console.WriteLine("Correct password!!");
            }
            catch(InvalidPasswordException e)
            {
                Console.WriteLine("Except: "+e.ToString());
            }
        }
        
    }
}
