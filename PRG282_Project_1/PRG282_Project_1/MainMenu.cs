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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentInfoManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentInformation fsi = new FrmStudentInformation();
            fsi.ShowDialog();
        }

        private void btnModuleInfoManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModuleInformation fmi = new FrmModuleInformation();
            fmi.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
