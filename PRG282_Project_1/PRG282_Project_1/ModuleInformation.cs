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
    public partial class FrmModuleInformation : Form
    {
        DBConnection dbc;
        public FrmModuleInformation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelModule_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMenu mm = new FrmMainMenu();
            mm.Show();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DBConnection dbc = new DBConnection();
            string command = "SELECT tblModule.moduleCode,tblModule.moduleName,tblModule.moduleNQFLevel, tblModule.moduleCredits, tblModule.moduleDescription, tblLink.linkURL FROM tblModule INNER JOIN tblLink ON tblModule.moduleCode=tblLink.moduleCode order by tblModule.moduleCode;";

            DataTable studentDT = dbc.executeSqlCommand(command);

            dgvinfoModules.DataSource = studentDT;
        }

        private void pnlStudentData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLinks_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddLInk_Click(object sender, EventArgs e)
        {
            if (txtLinks.Text == "")
            {
                MessageBox.Show("Please enter a link!");
            }

            else
            {
                lbDisplayLinks.Items.Add(txtLinks.Text);
                txtLinks.Clear();

            }
           
        }

        private void lbDisplayLinks_MouseClick(object sender, MouseEventArgs e)
        {
           

      
        }

        private void btnRemoveLink_Click(object sender, EventArgs e)
        {
            if (lbDisplayLinks.SelectedIndex >= 0)
                lbDisplayLinks.Items.RemoveAt(lbDisplayLinks.SelectedIndex);
        }

        private void lbDisplayLinks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lbDisplayLinks.SelectedIndex >= 0)
                    System.Diagnostics.Process.Start(lbDisplayLinks.SelectedItem.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvinfoModules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvinfoModules.SelectedRows.Count > 0)
            {
                txtModuleCode.Text = dgvinfoModules.SelectedRows[0].Cells[0].Value.ToString();
                txtModuleName.Text = dgvinfoModules.SelectedRows[0].Cells[1].Value.ToString();
                txtNQFlevel.Text = dgvinfoModules.SelectedRows[0].Cells[2].Value.ToString();
                txtCredits.Text = dgvinfoModules.SelectedRows[0].Cells[3].Value.ToString();
                txtModuleDescription.Text = dgvinfoModules.SelectedRows[0].Cells[4].Value.ToString();


                string command = "Select linkURL from tblLink where moduleCode = " + txtModuleCode.Text + "";

                DataTable DT = dbc.executeSqlCommand(command);

                lbDisplayLinks.Items.Clear();

                if (DT != null)
                {
                    foreach (var link in DT.AsEnumerable())
                    {
                        lbDisplayLinks.Items.Add(link[0]);
                    }

                }

            }
        }

        private void FrmModuleInformation_Load(object sender, EventArgs e)
        {
            dbc = new DBConnection();
        }
    }
}
