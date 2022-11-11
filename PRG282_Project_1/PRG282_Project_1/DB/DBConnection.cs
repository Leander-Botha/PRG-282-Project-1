﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using System.Windows.Forms;

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
            string searchQuery = $"SELECT * FROM tblStudent WHERE studentNumber = '{studentNumber}'";
            return executeSqlCommand(searchQuery);    
        }

        public DataTable DisplayAll()
        {
            string searchQuery = $"SELECT * FROM tblStudent";
            return executeSqlCommand(searchQuery);
        }

        public void Create(int studentNumber, string studentFirstName, string studentSurname, string studentDOB, object studentImage, string studentPhone, string studentAddress, string studentGender)
        {
            //string createQuery = $"INSERT INTO tblStudent VALUES('{studentNumber}','{studentFirstName}','{studentSurname}','{studentDOB}','{studentImage}','{studentPhone}','{studentAddress}','{studentGender}')";
            string createQuery = "INSERT INTO tblStudent VALUES(@studentNumber,@studentFirstName,@studentSurname,@studentDOB,@studentImage,@studentPhone,@studentAddress,@studentGender)";
            //return executeSqlCommand(createQuery);

            SqlCommand cmd = new SqlCommand(createQuery, this.Sqlcon);
            
                Sqlcon.Open();
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                cmd.Parameters.AddWithValue("@studentFirstName", studentFirstName);
                cmd.Parameters.AddWithValue("@studentSurname", studentSurname);
                cmd.Parameters.AddWithValue("@studentDOB", studentDOB);
                cmd.Parameters.AddWithValue("@studentImage", studentImage);
                cmd.Parameters.AddWithValue("@studentPhone", studentPhone);
                cmd.Parameters.AddWithValue("@studentAddress", studentAddress);
                cmd.Parameters.AddWithValue("@studentGender", studentGender);
                cmd.ExecuteNonQuery();
                Sqlcon.Close();
        }

        public void Delete(int studentNumber) 
        {
            string deleteQuery = "DELETE FROM tblStudent WHERE studentNumber = @studentNumber";

            if (MessageBox.Show("Are you sure you want to delete data for student with ID: "+studentNumber+"? this cannot be undone.","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                SqlCommand cmd = new SqlCommand(deleteQuery, this.Sqlcon);

                Sqlcon.Open();
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                cmd.ExecuteNonQuery();
                Sqlcon.Close();

                MessageBox.Show("Details for Student with ID: " + studentNumber + " has been deleted.", "Delete");
            }



        }

        public void Update(int studentNumber, string studentFirstName, string studentSurname, string studentDOB, object studentImage, string studentPhone, string studentAddress, string studentGender) 
        {
            string createQuery = "UPDATE tblStudent SET studentFirstName = @studentFirstName, studentSurname = @studentSurname, studentDOB = @studentDOB, studentImage = @studentImage, studentPhone = @studentPhone, studentAddress = @studentAddress, studentGender = @studentGender WHERE studentNumber = @studentNumber";

            SqlCommand cmd = new SqlCommand(createQuery, this.Sqlcon);

            Sqlcon.Open();
            cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
            cmd.Parameters.AddWithValue("@studentFirstName", studentFirstName);
            cmd.Parameters.AddWithValue("@studentSurname", studentSurname);
            cmd.Parameters.AddWithValue("@studentDOB", studentDOB);
            cmd.Parameters.AddWithValue("@studentImage", studentImage);
            cmd.Parameters.AddWithValue("@studentPhone", studentPhone);
            cmd.Parameters.AddWithValue("@studentAddress", studentAddress);
            cmd.Parameters.AddWithValue("@studentGender", studentGender);
            cmd.ExecuteNonQuery();
            Sqlcon.Close();

            MessageBox.Show("Details for Student with ID: " + studentNumber + " has been updated.", "Update");

        }

        //Converts an image to bytes and returns the bytes to be stored in the database.
        public object ConvertImageToBytes(PictureBox picStudent) 
        {
            var image = new ImageConverter().ConvertTo(picStudent.Image, typeof(byte[]));
            return image;
        }


    }
}
