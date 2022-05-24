
namespace LibrarySystem
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.GrpNewForm = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCourse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.cmbShowPass = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ChkVisitor = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ChkEnrolled = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GridUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GrpNewForm.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnEdit);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1914, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Users";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(433, 43);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(205, 59);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(222, 43);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(205, 59);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(11, 43);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(205, 59);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // GrpNewForm
            // 
            this.GrpNewForm.Controls.Add(this.flowLayoutPanel1);
            this.GrpNewForm.Controls.Add(this.flowLayoutPanel2);
            this.GrpNewForm.Location = new System.Drawing.Point(11, 114);
            this.GrpNewForm.Name = "GrpNewForm";
            this.GrpNewForm.Size = new System.Drawing.Size(848, 776);
            this.GrpNewForm.TabIndex = 6;
            this.GrpNewForm.TabStop = false;
            this.GrpNewForm.Text = "User Information";
            this.GrpNewForm.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TxtName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.TxtUsn);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cmbRole);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.CmbPosition);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.cmbGender);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.CmbCourse);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.TxtYear);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.TxtEmail);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.TxtContact);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.TxtPassword);
            this.flowLayoutPanel1.Controls.Add(this.cmbShowPass);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.ChkVisitor);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.ChkEnrolled);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.CmbStatus);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(842, 676);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(305, 13);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(512, 31);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "USN";
            // 
            // TxtUsn
            // 
            this.TxtUsn.Location = new System.Drawing.Point(305, 50);
            this.TxtUsn.Name = "TxtUsn";
            this.TxtUsn.Size = new System.Drawing.Size(512, 31);
            this.TxtUsn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.cmbRole.Location = new System.Drawing.Point(305, 87);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(512, 33);
            this.cmbRole.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Position";
            // 
            // CmbPosition
            // 
            this.CmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Items.AddRange(new object[] {
            "Administrator",
            "Professor",
            "Student"});
            this.CmbPosition.Location = new System.Drawing.Point(305, 126);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(512, 33);
            this.CmbPosition.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(305, 165);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(512, 33);
            this.cmbGender.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Course";
            // 
            // CmbCourse
            // 
            this.CmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCourse.FormattingEnabled = true;
            this.CmbCourse.Location = new System.Drawing.Point(305, 204);
            this.CmbCourse.Name = "CmbCourse";
            this.CmbCourse.Size = new System.Drawing.Size(512, 33);
            this.CmbCourse.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Year";
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(305, 243);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(512, 31);
            this.TxtYear.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 36);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(305, 280);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(512, 31);
            this.TxtEmail.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contact No";
            // 
            // TxtContact
            // 
            this.TxtContact.Location = new System.Drawing.Point(305, 317);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(512, 31);
            this.TxtContact.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(13, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(305, 354);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(512, 31);
            this.TxtPassword.TabIndex = 11;
            // 
            // cmbShowPass
            // 
            this.cmbShowPass.Location = new System.Drawing.Point(13, 391);
            this.cmbShowPass.Name = "cmbShowPass";
            this.cmbShowPass.Padding = new System.Windows.Forms.Padding(295, 0, 0, 0);
            this.cmbShowPass.Size = new System.Drawing.Size(804, 53);
            this.cmbShowPass.TabIndex = 12;
            this.cmbShowPass.Text = "Show Password";
            this.cmbShowPass.UseVisualStyleBackColor = true;
            this.cmbShowPass.CheckedChanged += new System.EventHandler(this.cmbShowPass_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(13, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 36);
            this.label11.TabIndex = 25;
            this.label11.Text = "Is a visitor?";
            // 
            // ChkVisitor
            // 
            this.ChkVisitor.Location = new System.Drawing.Point(305, 450);
            this.ChkVisitor.Name = "ChkVisitor";
            this.ChkVisitor.Size = new System.Drawing.Size(396, 29);
            this.ChkVisitor.TabIndex = 13;
            this.ChkVisitor.Text = "Yes";
            this.ChkVisitor.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(13, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 36);
            this.label13.TabIndex = 29;
            this.label13.Text = "Is Enrolled?";
            // 
            // ChkEnrolled
            // 
            this.ChkEnrolled.Location = new System.Drawing.Point(305, 486);
            this.ChkEnrolled.Name = "ChkEnrolled";
            this.ChkEnrolled.Size = new System.Drawing.Size(396, 29);
            this.ChkEnrolled.TabIndex = 28;
            this.ChkEnrolled.Text = "Yes";
            this.ChkEnrolled.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(13, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 36);
            this.label12.TabIndex = 27;
            this.label12.Text = "Status";
            // 
            // CmbStatus
            // 
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "active",
            "deactivated"});
            this.CmbStatus.Location = new System.Drawing.Point(305, 522);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(512, 33);
            this.CmbStatus.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BtnSave);
            this.flowLayoutPanel2.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 703);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(842, 70);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(205, 59);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(214, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(205, 59);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Close";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GridUsers
            // 
            this.GridUsers.AllowUserToAddRows = false;
            this.GridUsers.AllowUserToDeleteRows = false;
            this.GridUsers.AllowUserToResizeRows = false;
            this.GridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.GridUsers.Location = new System.Drawing.Point(0, 108);
            this.GridUsers.MultiSelect = false;
            this.GridUsers.Name = "GridUsers";
            this.GridUsers.ReadOnly = true;
            this.GridUsers.RowHeadersWidth = 82;
            this.GridUsers.RowTemplate.Height = 33;
            this.GridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsers.Size = new System.Drawing.Size(1914, 998);
            this.GridUsers.TabIndex = 1;
            this.GridUsers.SelectionChanged += new System.EventHandler(this.GridBookCategory_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 980);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1914, 126);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbFilter);
            this.groupBox3.Controls.Add(this.TxtSearch);
            this.groupBox3.Controls.Add(this.BtnSearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1218, 126);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // CmbFilter
            // 
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Name",
            "USN",
            "Email"});
            this.CmbFilter.Location = new System.Drawing.Point(599, 43);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(355, 33);
            this.CmbFilter.TabIndex = 6;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(6, 43);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(587, 31);
            this.TxtSearch.TabIndex = 4;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(960, 34);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(239, 49);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrpNewForm);
            this.Controls.Add(this.GridUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1914, 1106);
            this.Load += new System.EventHandler(this.Users_Load);
            this.groupBox1.ResumeLayout(false);
            this.GrpNewForm.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridUsers;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.GroupBox GrpNewForm;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ChkVisitor;
        private System.Windows.Forms.CheckBox cmbShowPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ChkEnrolled;
    }
}
