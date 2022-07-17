using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_managment.DataBase.Repository;

namespace user_managment.ApplicationLogic.Validations
{
    internal class UserValidation : Validation
    {
        public static bool IsNameValid(string name)
        {
            if (Validation.IsOnlyLetters(name))
            {
                return true;
            }
            Console.WriteLine("The name you entered is incorrect, make sure the name contains only letters, the first letter is capitalized, and the length is greater than 3 and less than 30.");
            return false;
        }

        public static bool IsLastNameValid(string lastName)
        {
            if (Validation.IsOnlyLetters(lastName))
            {
                return true;
            }
            Console.WriteLine("The surnam you entered is incorrect, make sure the name contains only letters, the first letter is capitalized, and the length is greater than 3 and less than 30.");

            return false;
        }

        public static bool IsValidEmail(string email)
        {
            if (Validation.IsEmailContains(email))
            {
                return true;
            }
            Console.WriteLine("Email must be like that exampleemail@code.edu.az");
            return false;
        }

        public static bool IsUserExistsByEmail(string email)
        {
            if (!UserRepository.IsEmailExists(email))
            {
                return true;
            }
            Console.WriteLine("Email already exists");
            return false;
        }

        public static bool IsPasswordValid(string password)
        {
            if (Validation.IsPasswordContains(password))
            {
                return true;
            }
            Console.WriteLine("In password must be one Upper case , one lower case , and pass must be upper than 8");
            return false;
        }

        public static bool IsPasswordSame(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }
            return false;
        }
    }
}
