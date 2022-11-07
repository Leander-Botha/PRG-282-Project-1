using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_1
{
    internal class FileHandler
    {
        public FileHandler()
        {

        }

        public List<User> Read()
        {
            List<User> employeeList = new List<User>();
            FileStream path = new FileStream("users.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(path);

            //string[] data;
            using (sr)
            {
                string line = string.Empty;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] data = line.Split(',');
                    employeeList.Add(new User(data[0], data[1]));

                    line = sr.ReadLine();
                }
            }

            return employeeList;
        }

        public void Write(string username, string password)
        {
            FileStream path = new FileStream("users.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(path);

            string line = username + "," + password;
            sw.WriteLine(line);
            sw.Close();

        }
    }
}

