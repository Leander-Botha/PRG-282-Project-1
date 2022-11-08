namespace PRG282_Project_1
{
    partial class FrmStudentInformation
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStudent = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.pnlStudentData.Controls.Add(this.btnDelete);
            this.pnlStudentData.Controls.Add(this.btnCancel);
            this.pnlStudentData.Controls.Add(this.comboBox1);
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
            this.pnlStudentData.Location = new System.Drawing.Point(92, 169);
            this.pnlStudentData.Margin = new System.Windows.Forms.Padding(6);
            this.pnlStudentData.Name = "pnlStudentData";
            this.pnlStudentData.Size = new System.Drawing.Size(724, 1037);
            this.pnlStudentData.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 963);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 44);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 962);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(316, 848);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 963);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(298, 292);
            this.picStudent.Margin = new System.Windows.Forms.Padding(6);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(238, 115);
            this.picStudent.TabIndex = 21;
            this.picStudent.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(316, 127);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 31);
            this.txtName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 44);
            this.label9.TabIndex = 19;
            this.label9.Text = "Student Name:";
            // 
            // dtpStudent
            // 
            this.dtpStudent.Location = new System.Drawing.Point(316, 469);
            this.dtpStudent.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStudent.Name = "dtpStudent";
            this.dtpStudent.Size = new System.Drawing.Size(196, 31);
            this.dtpStudent.TabIndex = 18;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(18, 962);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 44);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(316, 569);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(6);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(196, 33);
            this.cbxGender.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 854);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 44);
            this.label8.TabIndex = 16;
            this.label8.Text = "Module Codes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 765);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 44);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 673);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 44);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 567);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 44);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(316, 675);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 31);
            this.txtPhone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date Of Birth:";
            // 
            // txtStudentNr
            // 
            this.txtStudentNr.Location = new System.Drawing.Point(316, 50);
            this.txtStudentNr.Margin = new System.Windows.Forms.Padding(6);
            this.txtStudentNr.Name = "txtStudentNr";
            this.txtStudentNr.Size = new System.Drawing.Size(196, 31);
            this.txtStudentNr.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Image:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(316, 765);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 31);
            this.txtAddress.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Number:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(316, 204);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(6);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(196, 31);
            this.txtSurname.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 44);
            this.label10.TabIndex = 9;
            this.label10.Text = "Student Information:";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(444, 50);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(150, 44);
            this.btnSearchStudent.TabIndex = 12;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearchStudent);
            this.pnlSearch.Location = new System.Drawing.Point(884, 169);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(6);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(634, 135);
            this.pnlSearch.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 44);
            this.label11.TabIndex = 14;
            this.label11.Text = "Student Number:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(232, 50);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 31);
            this.txtSearch.TabIndex = 13;
            // 
            // dgvinfo
            // 
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Location = new System.Drawing.Point(884, 435);
            this.dgvinfo.Margin = new System.Windows.Forms.Padding(6);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowHeadersWidth = 82;
            this.dgvinfo.Size = new System.Drawing.Size(1158, 771);
            this.dgvinfo.TabIndex = 14;
            // 
            // FrmStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2066, 1229);
            this.Controls.Add(this.dgvinfo);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlStudentData);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmStudentInformation";
            this.Text = "Student Information";
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}