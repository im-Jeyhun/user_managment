using System;
using user_managment.ApplicationLogic;

namespace user_managment.UI
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine(" Welcome our application pls enter suitable command for contuniue : ");
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");
            while (true)
            {
                Console.Write("Enter suitable command :");
                string command = Console.ReadLine();
                if (command == "/register")
                {
                    Authentication.Register();

                }
                else if (command == "/login")
                {

                    Authentication.Login();

                }
                else if (command == "/exit")
                {
                    Console.WriteLine("Thanks for using our application");
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found ...");
                }
            }
        }
    }
}
