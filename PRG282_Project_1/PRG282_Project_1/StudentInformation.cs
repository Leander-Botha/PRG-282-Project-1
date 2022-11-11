using PRG282_Project_1.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_1
{
    public partial class FrmStudentInformation : Form
    {
        DBConnection dbc;
        public FrmStudentInformation()
        {
            InitializeComponent();
        }

        //****Example to add to DB
        //DataTable checkUser = new DataTable();
        //checkUser = this.myDatabase.executeSqlCommand("SELECT * FROM tblEmployee WHERE employeeID='" + txtEmpID.Text + "' ");
        //    if (checkUser.Rows.Count > 0)
        //    {
        //        MessageBox.Show("The EmployeeID is duplicated", "Warning");
        //    }
        //    else
        //    {
        //        //Insert data into database
        //        this.myDatabase.executeSqlCommand("INSERT INTO tblEmployee ([employeeID],[employeeEmail],[employeePassword],[employeeFirstName],[employeeLastName],[employeeLevel],[employeePhoneNumber]) VALUES('" + int.Parse(txtEmpID.Text) + "','" + txtEmail.Text + "','" + txtPass.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtLevel.Text + "','" + txtPhone.Text + "')");
        //MessageBox.Show("The user is saved");
        //load_userAccount();
        //}


        //****Example to update record in DB
        // update user information
        //string sqlcommand = "UPDATE tblEmployee SET employeeEmail='" + txtEmail.Text + "', employeePassword='" + txtPass.Text + "', employeeFirstName='" + txtFName.Text + "', employeeLastName='" + txtLName.Text + "', employeePhoneNumber='" + txtPhone.Text + "' WHERE employeeID='" + txtEmpID.Text + "' ";
        //this.myDatabase.executeSqlCommand(sqlcommand);
        //MessageBox.Show("The user info is updated", "Warning");


        //****Example to delete record in DB
        //if (MessageBox.Show("Do you want to delete the user?", "Warnning", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //      string sqlcommand = "DELETE FROM tblEmployee WHERE employeeID='" + txtEmpID.Text + "'";
        //      this.myDatabase.executeSqlCommand(sqlcommand);
        //      MessageBox.Show("The user is deleted");
        //    }


    private void MainMenu_Load(object sender, EventArgs e)
        {
            dbc = new DBConnection();
            dgvInfo.DataSource = dbc.DisplayAll();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMenu mm = new FrmMainMenu();
            mm.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInfo.DataSource = dbc.DisplayAll();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.Create(int.Parse(txtStudentNr.Text),txtName.Text, txtSurname.Text, dtpStudent.Value.Date, picStudent.Image,txtPhone.Text,txtAddress.Text,cbxGender.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvInfo.DataSource = dbc.DisplayAll();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInfo.DataSource = dbc.Search(int.Parse(txtSearch.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
    }
}
