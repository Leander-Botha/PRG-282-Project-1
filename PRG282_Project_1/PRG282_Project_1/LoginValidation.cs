using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_1
{
    internal class LoginValidation
    {

        public bool Validate(string username, string password) 
        {
            FileHandler fileHandler = new FileHandler();
            List<User> userList = fileHandler.Read();
            bool loginStatus = false;

            foreach (var user in userList)
            {
                if(user.Username.Equals(username) && user.Password.Equals(password)) 
                {
                    loginStatus = true;
                    break;
                }
                else
                {
                    loginStatus = false;
                }
            }

            if (loginStatus == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Validate(string username)
        {
            FileHandler fileHandler = new FileHandler();
            List<User> userList = fileHandler.Read();
            bool registrationStatus = false;

            foreach (var user in userList)
            {
                if (user.Username.Equals(username))
                {
                    registrationStatus = true;
                    break;
                }
                else
                {
                    registrationStatus = false;
                }
            }

            if (registrationStatus == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
