using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_managment.ApplicationLogic.Validations;
using user_managment.DataBase.Models;
using user_managment.DataBase.Repository;

namespace user_managment.ApplicationLogic
{
    internal class Authentication
    {
        public static void Register()
        {
            string name = GetName();
            string lastName = GetLastName();
            string email = GetEmail();
            string password = GetPassword();

            User user = UserRepository.Add(name, lastName, email, password);
            Console.WriteLine($"User added to sytstem {user.GetUserInfo()}");

        }

        public static void Login()
        {
            while (true)
            {
                Console.Write("Pls enter email : ");
                string email = Console.ReadLine();
                Console.Write("Pls enter password : ");
                string password = Console.ReadLine();
                if (UserRepository.IsUserExistsByEmailAndPassword(email, password))
                {

                    User user = UserRepository.GetByEmail(email);

                    if (user.IsAdmin)
                    {
                        Dashboard.AdminPanel(email);
                    }
                    else
                    {
                        Dashboard.UserPanel(email);
                    }
                }
                else
                {
                    Console.WriteLine("Email or password not correct.");
                }
               
            }

        }

        private static string GetName()
        {
            bool isEceptionValid;
            string name = null;
            do
            {
                try
                {

                    Console.Write("Insert Name : ");
                    name = Console.ReadLine();
                    isEceptionValid = false;
                    if (name == "null")
                    {
                        throw new Exception("seflik var2");

                    }
                }
                catch (Exception)
                {

                    isEceptionValid = true;
                    throw new Exception("seflik var");
                }

            } while (isEceptionValid || !UserValidation.IsNameValid(name));



            while (!UserValidation.IsNameValid(name))
            {
                Console.Write("Pls enter name again : ");
                name = Console.ReadLine();
            }
            return name;
        }
        private static string GetLastName()
        {
            Console.Write("Insert surname : ");
            string lastName = Console.ReadLine();
            while (!UserValidation.IsLastNameValid(lastName))
            {
                Console.Write("Pls enter surname again : ");
                lastName = Console.ReadLine();
            }
            return lastName;
        }
        private static string GetEmail()
        {
            Console.Write("Insert email : ");
            string email = Console.ReadLine();
            while (!UserValidation.IsValidEmail(email) || !UserValidation.IsUserExistsByEmail(email))
            {
                Console.Write("Pls enter email again : ");
                email = Console.ReadLine();
            }
            return email;
        }
        private static string GetPassword()
        {
            Console.Write("Insert password : ");
            string password = Console.ReadLine();

            while (!UserValidation.IsPasswordValid(password))
            {
                Console.Write("Pasword not correct pls enter password correctly : ");
                password = Console.ReadLine();

            }
            Console.Write("Insert password again : ");
            string conPass = Console.ReadLine();
            while (!UserValidation.IsPasswordSame(password, conPass))
            {
                Console.Write("Passwords must be same pls insert same password : ");
                conPass = Console.ReadLine();
            }
            return password;
        }
    }
}
