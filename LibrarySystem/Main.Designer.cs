
namespace LibrarySystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUserId = new System.Windows.Forms.Label();
            this.BtnMyAccount = new System.Windows.Forms.Button();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnRequest = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UControlProcessStudent = new LibrarySystem.ProcessEnrolledStudents();
            this.UControlBookTransaction = new LibrarySystem.BookTransaction();
            this.UControlHome = new LibrarySystem.Home();
            this.UControlBooks = new LibrarySystem.Books();
            this.UControlUsers = new LibrarySystem.Users();
            this.UControlBookCategories = new LibrarySystem.BookCategories();
            this.UControlReportDashboard = new LibrarySystem.ReportDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.LblUserId);
            this.panel1.Controls.Add(this.BtnMyAccount);
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 100);
            this.panel1.TabIndex = 0;
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Location = new System.Drawing.Point(4, 0);
            this.LblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(74, 25);
            this.LblUserId.TabIndex = 3;
            this.LblUserId.Text = "UserId";
            this.LblUserId.Visible = false;
            // 
            // BtnMyAccount
            // 
            this.BtnMyAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(21)))));
            this.BtnMyAccount.FlatAppearance.BorderSize = 0;
            this.BtnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyAccount.ForeColor = System.Drawing.Color.White;
            this.BtnMyAccount.Location = new System.Drawing.Point(394, 13);
            this.BtnMyAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMyAccount.Name = "BtnMyAccount";
            this.BtnMyAccount.Size = new System.Drawing.Size(166, 73);
            this.BtnMyAccount.TabIndex = 1;
            this.BtnMyAccount.Text = "My Account";
            this.BtnMyAccount.UseVisualStyleBackColor = false;
            this.BtnMyAccount.Click += new System.EventHandler(this.BtnMyAccount_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(172, 38);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(82, 30);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BtnReturn);
            this.panel2.Controls.Add(this.BtnRequest);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.BtnReport);
            this.panel2.Controls.Add(this.BtnUsers);
            this.panel2.Controls.Add(this.BtnBooks);
            this.panel2.Controls.Add(this.BtnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(354, 1033);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 108);
            this.button1.TabIndex = 8;
            this.button1.Text = "Process Enrolled Students";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Image = ((System.Drawing.Image)(resources.GetObject("BtnReturn.Image")));
            this.BtnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturn.Location = new System.Drawing.Point(10, 783);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(334, 108);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Return Books";
            this.BtnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnRequest
            // 
            this.BtnRequest.FlatAppearance.BorderSize = 0;
            this.BtnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequest.ForeColor = System.Drawing.Color.White;
            this.BtnRequest.Image = ((System.Drawing.Image)(resources.GetObject("BtnRequest.Image")));
            this.BtnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRequest.Location = new System.Drawing.Point(10, 665);
            this.BtnRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRequest.Size = new System.Drawing.Size(334, 108);
            this.BtnRequest.TabIndex = 6;
            this.BtnRequest.Text = "Borrow Requests";
            this.BtnRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRequest.UseVisualStyleBackColor = true;
            this.BtnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 946);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(334, 77);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(10, 362);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(334, 108);
            this.BtnReport.TabIndex = 5;
            this.BtnReport.Text = "Reports";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsers.Image")));
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.Location = new System.Drawing.Point(10, 244);
            this.BtnUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(334, 108);
            this.BtnUsers.TabIndex = 4;
            this.BtnUsers.Text = "Users";
            this.BtnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnBooks
            // 
            this.BtnBooks.FlatAppearance.BorderSize = 0;
            this.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.ForeColor = System.Drawing.Color.White;
            this.BtnBooks.Image = ((System.Drawing.Image)(resources.GetObject("BtnBooks.Image")));
            this.BtnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooks.Location = new System.Drawing.Point(10, 127);
            this.BtnBooks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(334, 108);
            this.BtnBooks.TabIndex = 3;
            this.BtnBooks.Text = "Books";
            this.BtnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBooks.UseVisualStyleBackColor = true;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(10, 10);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(334, 108);
            this.BtnDashboard.TabIndex = 2;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UControlReportDashboard);
            this.panel3.Controls.Add(this.UControlProcessStudent);
            this.panel3.Controls.Add(this.UControlBookTransaction);
            this.panel3.Controls.Add(this.UControlHome);
            this.panel3.Controls.Add(this.UControlBooks);
            this.panel3.Controls.Add(this.UControlUsers);
            this.panel3.Controls.Add(this.UControlBookCategories);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(354, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1570, 1033);
            this.panel3.TabIndex = 2;
            // 
            // UControlProcessStudent
            // 
            this.UControlProcessStudent.BackColor = System.Drawing.Color.White;
            this.UControlProcessStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlProcessStudent.Location = new System.Drawing.Point(0, 0);
            this.UControlProcessStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UControlProcessStudent.Name = "UControlProcessStudent";
            this.UControlProcessStudent.Size = new System.Drawing.Size(1570, 1033);
            this.UControlProcessStudent.TabIndex = 5;
            // 
            // UControlBookTransaction
            // 
            this.UControlBookTransaction.BackColor = System.Drawing.Color.White;
            this.UControlBookTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlBookTransaction.Location = new System.Drawing.Point(0, 0);
            this.UControlBookTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UControlBookTransaction.Name = "UControlBookTransaction";
            this.UControlBookTransaction.Size = new System.Drawing.Size(1570, 1033);
            this.UControlBookTransaction.TabIndex = 4;
            // 
            // UControlHome
            // 
            this.UControlHome.BackColor = System.Drawing.Color.White;
            this.UControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlHome.Location = new System.Drawing.Point(0, 0);
            this.UControlHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UControlHome.Name = "UControlHome";
            this.UControlHome.Size = new System.Drawing.Size(1570, 1033);
            this.UControlHome.TabIndex = 3;
            // 
            // UControlBooks
            // 
            this.UControlBooks.BackColor = System.Drawing.Color.White;
            this.UControlBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlBooks.Location = new System.Drawing.Point(0, 0);
            this.UControlBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UControlBooks.Name = "UControlBooks";
            this.UControlBooks.Size = new System.Drawing.Size(1570, 1033);
            this.UControlBooks.TabIndex = 2;
            // 
            // UControlUsers
            // 
            this.UControlUsers.BackColor = System.Drawing.Color.White;
            this.UControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlUsers.Location = new System.Drawing.Point(0, 0);
            this.UControlUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UControlUsers.Name = "UControlUsers";
            this.UControlUsers.Size = new System.Drawing.Size(1570, 1033);
            this.UControlUsers.TabIndex = 1;
            // 
            // UControlBookCategories
            // 
            this.UControlBookCategories.BackColor = System.Drawing.Color.White;
            this.UControlBookCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlBookCategories.Location = new System.Drawing.Point(0, 0);
            this.UControlBookCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UControlBookCategories.Name = "UControlBookCategories";
            this.UControlBookCategories.Size = new System.Drawing.Size(1570, 1033);
            this.UControlBookCategories.TabIndex = 0;
            // 
            // UControlReportDashboard
            // 
            this.UControlReportDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlReportDashboard.Location = new System.Drawing.Point(0, 0);
            this.UControlReportDashboard.Name = "UControlReportDashboard";
            this.UControlReportDashboard.Size = new System.Drawing.Size(1570, 1033);
            this.UControlReportDashboard.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1133);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label1;
        private BookCategories UControlBookCategories;
        private Users UControlUsers;
        private System.Windows.Forms.Button BtnMyAccount;
        private System.Windows.Forms.Label LblUserId;
        private Books UControlBooks;
        private System.Windows.Forms.Button BtnRequest;
        private System.Windows.Forms.Button BtnReturn;
        private Home UControlHome;
        private BookTransaction UControlBookTransaction;
        private System.Windows.Forms.Button button1;
        private ProcessEnrolledStudents UControlProcessStudent;
        private ReportDashboard UControlReportDashboard;
    }
}