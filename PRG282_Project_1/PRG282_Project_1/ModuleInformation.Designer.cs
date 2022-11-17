namespace PRG282_Project_1
{
    partial class FrmModuleInformation
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
            this.pnlStudentData = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDisplayLinks = new System.Windows.Forms.ListBox();
            this.btnAddLInk = new System.Windows.Forms.Button();
            this.txtLinks = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtNQFlevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreateModule = new System.Windows.Forms.Button();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModuleDescription = new System.Windows.Forms.TextBox();
            this.btnCancelModule = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.dgvinfoModules = new System.Windows.Forms.DataGridView();
            this.btnClearFrm = new System.Windows.Forms.Button();
            this.pnlStudentData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfoModules)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, -339);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "Student Information:";
            // 
            // pnlStudentData
            // 
            this.pnlStudentData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlStudentData.Controls.Add(this.groupBox1);
            this.pnlStudentData.Controls.Add(this.txtCredits);
            this.pnlStudentData.Controls.Add(this.txtNQFlevel);
            this.pnlStudentData.Controls.Add(this.label6);
            this.pnlStudentData.Controls.Add(this.label5);
            this.pnlStudentData.Controls.Add(this.btnRead);
            this.pnlStudentData.Controls.Add(this.btnDeleteModule);
            this.pnlStudentData.Controls.Add(this.btnUpdateModule);
            this.pnlStudentData.Controls.Add(this.txtModuleName);
            this.pnlStudentData.Controls.Add(this.label9);
            this.pnlStudentData.Controls.Add(this.btnCreateModule);
            this.pnlStudentData.Controls.Add(this.txtModuleCode);
            this.pnlStudentData.Controls.Add(this.label2);
            this.pnlStudentData.Controls.Add(this.label1);
            this.pnlStudentData.Controls.Add(this.txtModuleDescription);
            this.pnlStudentData.Location = new System.Drawing.Point(22, 60);
            this.pnlStudentData.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStudentData.Name = "pnlStudentData";
            this.pnlStudentData.Size = new System.Drawing.Size(509, 525);
            this.pnlStudentData.TabIndex = 10;
            this.pnlStudentData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStudentData_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveLink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbDisplayLinks);
            this.groupBox1.Controls.Add(this.btnAddLInk);
            this.groupBox1.Controls.Add(this.txtLinks);
            this.groupBox1.Location = new System.Drawing.Point(20, 273);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(469, 167);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // btnRemoveLink
            // 
            this.btnRemoveLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLink.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveLink.Location = new System.Drawing.Point(356, 133);
            this.btnRemoveLink.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveLink.Name = "btnRemoveLink";
            this.btnRemoveLink.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveLink.TabIndex = 35;
            this.btnRemoveLink.Text = "Remove Link";
            this.btnRemoveLink.UseVisualStyleBackColor = true;
            this.btnRemoveLink.Click += new System.EventHandler(this.btnRemoveLink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Online Resources:";
            // 
            // lbDisplayLinks
            // 
            this.lbDisplayLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDisplayLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayLinks.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDisplayLinks.FormattingEnabled = true;
            this.lbDisplayLinks.ItemHeight = 16;
            this.lbDisplayLinks.Location = new System.Drawing.Point(145, 61);
            this.lbDisplayLinks.Margin = new System.Windows.Forms.Padding(2);
            this.lbDisplayLinks.Name = "lbDisplayLinks";
            this.lbDisplayLinks.Size = new System.Drawing.Size(303, 52);
            this.lbDisplayLinks.TabIndex = 32;
            this.lbDisplayLinks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbDisplayLinks_MouseClick);
            this.lbDisplayLinks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbDisplayLinks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbDisplayLinks_MouseDoubleClick);
            // 
            // btnAddLInk
            // 
            this.btnAddLInk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLInk.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddLInk.Location = new System.Drawing.Point(373, 17);
            this.btnAddLInk.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLInk.Name = "btnAddLInk";
            this.btnAddLInk.Size = new System.Drawing.Size(83, 28);
            this.btnAddLInk.TabIndex = 34;
            this.btnAddLInk.Text = "Add Link";
            this.btnAddLInk.UseVisualStyleBackColor = true;
            this.btnAddLInk.Click += new System.EventHandler(this.btnAddLInk_Click);
            // 
            // txtLinks
            // 
            this.txtLinks.Location = new System.Drawing.Point(145, 21);
            this.txtLinks.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinks.Name = "txtLinks";
            this.txtLinks.Size = new System.Drawing.Size(214, 22);
            this.txtLinks.TabIndex = 33;
            this.txtLinks.TextChanged += new System.EventHandler(this.txtLinks_TextChanged);
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(199, 180);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(2);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(132, 22);
            this.txtCredits.TabIndex = 31;
            this.txtCredits.TextChanged += new System.EventHandler(this.txtCredits_TextChanged);
            // 
            // txtNQFlevel
            // 
            this.txtNQFlevel.Location = new System.Drawing.Point(199, 130);
            this.txtNQFlevel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNQFlevel.Name = "txtNQFlevel";
            this.txtNQFlevel.Size = new System.Drawing.Size(132, 22);
            this.txtNQFlevel.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label6.Location = new System.Drawing.Point(37, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Credits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label5.Location = new System.Drawing.Point(37, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "NQF Level:";
            // 
            // btnRead
            // 
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Location = new System.Drawing.Point(145, 467);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 28);
            this.btnRead.TabIndex = 25;
            this.btnRead.Text = "Read/ViewAll";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteModule.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteModule.Location = new System.Drawing.Point(382, 467);
            this.btnDeleteModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteModule.TabIndex = 23;
            this.btnDeleteModule.Text = "Delete";
            this.btnDeleteModule.UseVisualStyleBackColor = true;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateModule.Location = new System.Drawing.Point(265, 467);
            this.btnUpdateModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateModule.TabIndex = 14;
            this.btnUpdateModule.Text = "Update";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(199, 81);
            this.txtModuleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(132, 22);
            this.txtModuleName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Module Name:";
            // 
            // btnCreateModule
            // 
            this.btnCreateModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateModule.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCreateModule.Location = new System.Drawing.Point(27, 467);
            this.btnCreateModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateModule.Name = "btnCreateModule";
            this.btnCreateModule.Size = new System.Drawing.Size(100, 28);
            this.btnCreateModule.TabIndex = 10;
            this.btnCreateModule.Text = "Create";
            this.btnCreateModule.UseVisualStyleBackColor = true;
            this.btnCreateModule.Click += new System.EventHandler(this.btnCreateModule_Click);
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(199, 33);
            this.txtModuleCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(132, 22);
            this.txtModuleCode.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Module Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Module Code:";
            // 
            // txtModuleDescription
            // 
            this.txtModuleDescription.Location = new System.Drawing.Point(199, 227);
            this.txtModuleDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleDescription.Name = "txtModuleDescription";
            this.txtModuleDescription.Size = new System.Drawing.Size(279, 22);
            this.txtModuleDescription.TabIndex = 8;
            // 
            // btnCancelModule
            // 
            this.btnCancelModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelModule.Location = new System.Drawing.Point(565, 527);
            this.btnCancelModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelModule.Name = "btnCancelModule";
            this.btnCancelModule.Size = new System.Drawing.Size(463, 28);
            this.btnCancelModule.TabIndex = 22;
            this.btnCancelModule.Text = "Back";
            this.btnCancelModule.UseVisualStyleBackColor = true;
            this.btnCancelModule.Click += new System.EventHandler(this.btnCancelModule_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Module Information:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearchModule);
            this.pnlSearch.Location = new System.Drawing.Point(565, 60);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(463, 68);
            this.pnlSearch.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Module Code:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchModule.Location = new System.Drawing.Point(344, 21);
            this.btnSearchModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(100, 28);
            this.btnSearchModule.TabIndex = 12;
            this.btnSearchModule.Text = "Search Student";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // dgvinfoModules
            // 
            this.dgvinfoModules.AllowUserToAddRows = false;
            this.dgvinfoModules.AllowUserToDeleteRows = false;
            this.dgvinfoModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfoModules.Location = new System.Drawing.Point(565, 164);
            this.dgvinfoModules.Margin = new System.Windows.Forms.Padding(4);
            this.dgvinfoModules.MultiSelect = false;
            this.dgvinfoModules.Name = "dgvinfoModules";
            this.dgvinfoModules.ReadOnly = true;
            this.dgvinfoModules.RowHeadersWidth = 82;
            this.dgvinfoModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinfoModules.ShowEditingIcon = false;
            this.dgvinfoModules.Size = new System.Drawing.Size(463, 318);
            this.dgvinfoModules.TabIndex = 15;
            this.dgvinfoModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfoModules_CellClick);
            this.dgvinfoModules.SelectionChanged += new System.EventHandler(this.dgvinfoModules_SelectionChanged);
            // 
            // btnClearFrm
            // 
            this.btnClearFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFrm.Location = new System.Drawing.Point(398, 26);
            this.btnClearFrm.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFrm.Name = "btnClearFrm";
            this.btnClearFrm.Size = new System.Drawing.Size(133, 28);
            this.btnClearFrm.TabIndex = 24;
            this.btnClearFrm.Text = "Clear Form";
            this.btnClearFrm.UseVisualStyleBackColor = true;
            this.btnClearFrm.Click += new System.EventHandler(this.btnClearFrm_Click);
            // 
            // FrmModuleInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 614);
            this.Controls.Add(this.btnClearFrm);
            this.Controls.Add(this.dgvinfoModules);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlStudentData);
            this.Controls.Add(this.btnCancelModule);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmModuleInformation";
            this.Padding = new System.Windows.Forms.Padding(23, 0, 27, 32);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModuleInformation_FormClosing);
            this.Load += new System.EventHandler(this.FrmModuleInformation_Load);
            this.pnlStudentData.ResumeLayout(false);
            this.pnlStudentData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfoModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlStudentData;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnCancelModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreateModule;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModuleDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.DataGridView dgvinfoModules;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtNQFlevel;
        private System.Windows.Forms.ListBox lbDisplayLinks;
        private System.Windows.Forms.Button btnAddLInk;
        private System.Windows.Forms.TextBox txtLinks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveLink;
        private System.Windows.Forms.Button btnClearFrm;
    }
}