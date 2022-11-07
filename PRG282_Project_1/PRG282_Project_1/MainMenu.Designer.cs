namespace PRG282_Project_1
{
    partial class MainMenu
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
            this.pnlStudentData = new System.Windows.Forms.Panel();
            this.dtpStudent = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.pnlStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentData
            // 
            this.pnlStudentData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlStudentData.Controls.Add(this.comboBox1);
            this.pnlStudentData.Controls.Add(this.btnDelete);
            this.pnlStudentData.Controls.Add(this.btnUpdate);
            this.pnlStudentData.Controls.Add(this.picStudent);
            this.pnlStudentData.Controls.Add(this.txtName);
            this.pnlStudentData.Controls.Add(this.label9);
            this.pnlStudentData.Controls.Add(this.dtpStudent);
            this.pnlStudentData.Controls.Add(this.btnCreate);
            this.pnlStudentData.Controls.Add(this.cbxGender);
            this.pnlStudentData.Controls.Add(this.label8);
            this.pnlStudentData.Controls.Add(this.label7);
            this.pnlStudentData.Controls.Add(this.label6);
            this.pnlStudentData.Controls.Add(this.label5);
            this.pnlStudentData.Controls.Add(this.txtPhone);
            this.pnlStudentData.Controls.Add(this.label4);
            this.pnlStudentData.Controls.Add(this.txtStudentNr);
            this.pnlStudentData.Controls.Add(this.label3);
            this.pnlStudentData.Controls.Add(this.txtAddress);
            this.pnlStudentData.Controls.Add(this.label2);
            this.pnlStudentData.Controls.Add(this.label1);
            this.pnlStudentData.Controls.Add(this.txtSurname);
            this.pnlStudentData.Location = new System.Drawing.Point(46, 88);
            this.pnlStudentData.Name = "pnlStudentData";
            this.pnlStudentData.Size = new System.Drawing.Size(362, 539);
            this.pnlStudentData.TabIndex = 8;
            // 
            // dtpStudent
            // 
            this.dtpStudent.Location = new System.Drawing.Point(158, 244);
            this.dtpStudent.Name = "dtpStudent";
            this.dtpStudent.Size = new System.Drawing.Size(100, 20);
            this.dtpStudent.TabIndex = 18;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(158, 296);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(100, 21);
            this.cbxGender.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Module Codes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(158, 351);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date Of Birth:";
            // 
            // txtStudentNr
            // 
            this.txtStudentNr.Location = new System.Drawing.Point(158, 26);
            this.txtStudentNr.Name = "txtStudentNr";
            this.txtStudentNr.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNr.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Image:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(158, 398);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Number:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(158, 106);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Student Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 20;
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(149, 152);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(119, 60);
            this.picStudent.TabIndex = 21;
            this.picStudent.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Student Information:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(9, 500);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(222, 26);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 12;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(205, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(107, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearchStudent);
            this.pnlSearch.Location = new System.Drawing.Point(442, 88);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(317, 70);
            this.pnlSearch.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(116, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Student Number:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(158, 441);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // dgvinfo
            // 
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Location = new System.Drawing.Point(442, 226);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.Size = new System.Drawing.Size(579, 401);
            this.dgvinfo.TabIndex = 14;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 639);
            this.Controls.Add(this.dgvinfo);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlStudentData);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnlStudentData.ResumeLayout(false);
            this.pnlStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentData;
        private System.Windows.Forms.DateTimePicker dtpStudent;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvinfo;
    }
}