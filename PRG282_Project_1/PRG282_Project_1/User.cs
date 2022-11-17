using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_1
{
    //THIS CLASS REPRESTENTS THE USER INFORMATION FOR THE LOGIN.

    internal class User
    {
        string username;
        string password;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
