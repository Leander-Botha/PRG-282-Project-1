using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace PRG282_Project_1.DB
{
    internal class DBConnection
    {
        //Data source
        private string filePath;

        private string strcon()
        {
            string path = Environment.CurrentDirectory;
            string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\DB\BelgiumCampusDB.mdf"));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + newpath + @";Integrated Security=True;Connect Timeout=30";
        }
        //SQL connection object
        private SqlConnection Sqlcon;

        public DBConnection()
        {
            Sqlcon = new SqlConnection(this.strcon());
        }

        public DBConnection(string fileP)
        {
            this.filePath = fileP;
            Sqlcon = new SqlConnection(this.strcon());
        }

        public DataTable executeSqlCommand(string sqlCommand)
        {
            DataTable dtTable = new DataTable();
            try
            {
                //open sql connection
                this.Sqlcon.Open();
                //create sqlAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.Sqlcon);
                dataAdapter.Fill(dtTable);
                this.Sqlcon.Close();
            }
            catch (Exception error)
            {
                Console.Write(error.ToString());
                dtTable = null;
            }
            return dtTable;
        }

        public DataTable Search(int studentNumber) 
        { 
            string searchQuery = $"select * from [tblStudent] where studentNumber = '{studentNumber}'";
            return executeSqlCommand(searchQuery);    
        }

        public DataTable DisplayAll()
        {
            string searchQuery = $"select * from [tblStudent]";
            return executeSqlCommand(searchQuery);
        }

        public DataTable Create(int studentNumber, string studentFirstName, string studentSurname, DateTime studentDOB, Image studentImage, string studentPhone, string studentAddress, string studentGender)
        {
            string createQuery = $"INSERT INTO tblStudent VALUES('{studentNumber}','{studentFirstName}','{studentSurname}','{studentDOB}','{studentImage}','{studentPhone}','{studentAddress}','{studentGender}',";
            return executeSqlCommand(createQuery);
        }
    }
}
