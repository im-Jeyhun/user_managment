using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_managment.DataBase.Models;

namespace user_managment.DataBase.Repository
{
    internal class UserRepository
    {
        private static List<User> Users { get; set; } = new List<User>()
        {
            new User("Super","Admin", "admin@gmail.com","123321" , true )
        };

        public static User Add(string name, string lastName, string email, string password)
        {

            User user = new User(name, lastName, email, password);
            Users.Add(user);
            return user;
        }

        public static bool IsEmailExists(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public static User GetByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }
        public static bool IsUserExistsByEmailAndPassword(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }
            return false;

        }

        public static List<User> GetAll()
        {
            return Users;
        }

    }
}
