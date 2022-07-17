using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace user_managment.ApplicationLogic.Validations
{
    internal class Validation
    {
        public static bool IsOnlyLetters(string text)
        {
            string patterms = "^[A-Z][a-zA-z]{3,30}$";
            Regex regex = new Regex(patterms);
            return regex.IsMatch(text);
        }

        public static bool IsEmailContains(string email)
        {
            string patterns = /*@"^[\w]{10,30}+[@]+[code]+[\.]+[edu]+[\.]+[az]+$"*/ @"^([a-zA-Z0-9]{10,30})(@code\.edu\.az)$";
            Regex regexemail = new Regex(patterns);
            return regexemail.IsMatch(email);
        }

        public static bool IsPasswordContains(string password)
        {
            string patterns = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            Regex regexpassword = new Regex(patterns);
            return regexpassword.IsMatch(password);
        }
    }
}
