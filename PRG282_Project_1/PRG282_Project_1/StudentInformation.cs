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
using static System.Net.Mime.MediaTypeNames;

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
                
                dbc.Create(int.Parse(txtStudentNr.Text), txtName.Text, txtSurname.Text, dtpStudent.Text, dbc.ConvertImageToBytes(picStudent), txtPhone.Text, txtAddress.Text, cbxGender.Text);
                MessageBox.Show("Student sucessfully created");
                dgvInfo.DataSource = dbc.DisplayAll();

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

        private void picStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Supported Images |*jpg|*jpeg|*png";
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            { 
                picStudent.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbc.Delete(int.Parse(txtStudentNr.Text));
                dgvInfo.DataSource = dbc.DisplayAll();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.Update(int.Parse(txtStudentNr.Text), txtName.Text, txtSurname.Text, dtpStudent.Text, dbc.ConvertImageToBytes(picStudent), txtPhone.Text, txtAddress.Text, cbxGender.Text);
                dgvInfo.DataSource = dbc.DisplayAll();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dgvInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInfo.SelectedRows.Count > 0)
            {
                txtStudentNr.Text = dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvInfo.SelectedRows[0].Cells[1].Value.ToString();
                txtSurname.Text = dgvInfo.SelectedRows[0].Cells[2].Value.ToString();

                if (dgvInfo.SelectedRows[0].Cells[4].Value.ToString() != "")
                {
                    
                    picStudent.Image = (System.Drawing.Image)new ImageConverter().ConvertFrom(dgvInfo.SelectedRows[0].Cells[4].Value);
                }
                else
                {
                    picStudent.Image = Properties.Resources._default;
                }

                if (dgvInfo.SelectedRows[0].Cells[3].Value.ToString() != "")
                {

                    dtpStudent.Value = (DateTime)dgvInfo.SelectedRows[0].Cells[3].Value;
                }

                else
                {
                    dtpStudent.Value = DateTime.Now;
                }

                if(cbxGender.Items.Contains(dgvInfo.SelectedRows[0].Cells[7].Value.ToString()))
                {
                    cbxGender.SelectedIndex = cbxGender.Items.IndexOf(dgvInfo.SelectedRows[0].Cells[7].Value.ToString()); 
                }
                else
                {
                    cbxGender.SelectedIndex = 0; 
                }

                txtPhone.Text = dgvInfo.SelectedRows[0].Cells[5].Value.ToString();
                txtAddress.Text = dgvInfo.SelectedRows[0].Cells[6].Value.ToString();

            
            }
          
        }

        private void cbxModules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
