using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_1
{
    internal class FileHandler
    {
        //THIS CLASS HANDLES ALL OF THE READ AND WRITE OPERATIONS TO AND FROM FILES.
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
                sr.Close();
                path.Close();
            }

            return employeeList;
        }

        public void Write(string username, string password)
        {
            try
            {
                FileStream path = new FileStream("users.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(path); string line = username + "," + password;

                using(sw)
                {
                    sw.WriteLine(line);
                   
                }
                sw.Close();
                path.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            
        }
    }
}

