using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_managment.DataBase.Models;
using user_managment.DataBase.Repository;
using user_managment.UI;

namespace user_managment.ApplicationLogic
{
    public static partial class Dashboard
    {
        public static void AdminPanel(string email)
        {
            User user = UserRepository.GetByEmail(email);
            Console.WriteLine($"Admin succesfully foined : {user.GetUserInfo()}");
            while (true)
            {
                Console.WriteLine("Insert /show-users command for see all users or isnert /logout for signout");
                string command = Console.ReadLine();
                if (command == "/show-users")
                {
                    List<User> users = UserRepository.GetAll();
                    foreach (User user1 in users)
                    {

                        Console.WriteLine(user1.GetUserInfoForAdmin());

                    }

                }
                else if (command == "/logout")
                {
                    Program.Main(new string[] { });
                    break;
                }
                else
                {
                    Console.WriteLine("Command not fount ....");
                }
            }
        }
    }
    public static partial class Dashboard
    {

        public static void UserPanel(string email)
        {
            User user = UserRepository.GetByEmail(email);
            Console.WriteLine($"User succesfully joined : {user.GetUserInfo()}");
            while (true)
            {
                Console.WriteLine("Insert /logout for signout from account ");
                string command = Console.ReadLine();
                if (command == "/logout")
                {
                    Program.Main(new string[] { });
                    break;
                }
                else
                {
                    Console.WriteLine("User can only signout ..");
                }
            }


        }
    }
}
