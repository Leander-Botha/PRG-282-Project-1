namespace PRG282_Project_1
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.btnStudentInfoManager = new System.Windows.Forms.Button();
            this.btnModuleInfoManager = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(813, 44);
            this.label10.TabIndex = 10;
            this.label10.Text = "Student And Module Information Manager";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnStudentInfoManager
            // 
            this.btnStudentInfoManager.Location = new System.Drawing.Point(376, 290);
            this.btnStudentInfoManager.Name = "btnStudentInfoManager";
            this.btnStudentInfoManager.Size = new System.Drawing.Size(318, 91);
            this.btnStudentInfoManager.TabIndex = 11;
            this.btnStudentInfoManager.Text = "Manage Student Information";
            this.btnStudentInfoManager.UseVisualStyleBackColor = true;
            this.btnStudentInfoManager.Click += new System.EventHandler(this.btnStudentInfoManager_Click);
            // 
            // btnModuleInfoManager
            // 
            this.btnModuleInfoManager.Location = new System.Drawing.Point(376, 418);
            this.btnModuleInfoManager.Name = "btnModuleInfoManager";
            this.btnModuleInfoManager.Size = new System.Drawing.Size(318, 91);
            this.btnModuleInfoManager.TabIndex = 12;
            this.btnModuleInfoManager.Text = "Manage Module Information";
            this.btnModuleInfoManager.UseVisualStyleBackColor = true;
            this.btnModuleInfoManager.Click += new System.EventHandler(this.btnModuleInfoManager_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 549);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(318, 91);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 759);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModuleInfoManager);
            this.Controls.Add(this.btnStudentInfoManager);
            this.Controls.Add(this.label10);
            this.Name = "FrmMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStudentInfoManager;
        private System.Windows.Forms.Button btnModuleInfoManager;
        private System.Windows.Forms.Button btnExit;
    }
}