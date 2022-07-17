using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_managment.DataBase.Models
{
    internal class User
    {
        private DateTime RegistrationDate { get; set; }

        private static int idCounter = 1;
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string name, string lastName, string email, string password)
        {
            Id = idCounter++;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            RegistrationDate = DateTime.Now;

        }
        public string GetUserInfo()
        {
            return $"Istifadeci adi : {Name} , soyadi : {LastName} , emaili : {Email} ";

        }

        public string GetUserInfoForAdmin()
        {
            return $"Istifadeci id : {Id} , Istifadeci adi : {Name} , soyadi : {LastName} , emaili : {Email} , qeydiyyat tarixi {RegistrationDate} ";

        }
    }
}
