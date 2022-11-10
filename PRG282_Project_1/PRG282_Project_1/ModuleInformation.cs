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
    }
}
