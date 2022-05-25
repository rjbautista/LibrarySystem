
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
            this.UControlReport = new LibrarySystem.ReportDashboard();
            this.UControlProcessStudent = new LibrarySystem.ProcessEnrolledStudents();
            this.UControlBookTransaction = new LibrarySystem.BookTransaction();
            this.UControlHome = new LibrarySystem.Home();
            this.UControlBooks = new LibrarySystem.Books();
            this.UControlUsers = new LibrarySystem.Users();
            this.UControlBookCategories = new LibrarySystem.BookCategories();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblUserId);
            this.panel1.Controls.Add(this.BtnMyAccount);
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2504, 100);
            this.panel1.TabIndex = 0;
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Location = new System.Drawing.Point(5, 0);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(74, 25);
            this.LblUserId.TabIndex = 3;
            this.LblUserId.Text = "UserId";
            this.LblUserId.Visible = false;
            // 
            // BtnMyAccount
            // 
            this.BtnMyAccount.Location = new System.Drawing.Point(354, 12);
            this.BtnMyAccount.Name = "BtnMyAccount";
            this.BtnMyAccount.Size = new System.Drawing.Size(198, 70);
            this.BtnMyAccount.TabIndex = 1;
            this.BtnMyAccount.Text = "My Account";
            this.BtnMyAccount.UseVisualStyleBackColor = true;
            this.BtnMyAccount.Click += new System.EventHandler(this.BtnMyAccount_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(148, 38);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(68, 25);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // panel2
            // 
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
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(354, 1104);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 107);
            this.button1.TabIndex = 8;
            this.button1.Text = "Process Enrolled Students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(10, 792);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(5);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(334, 107);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Return Books";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnRequest
            // 
            this.BtnRequest.Location = new System.Drawing.Point(10, 675);
            this.BtnRequest.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.Size = new System.Drawing.Size(334, 107);
            this.BtnRequest.TabIndex = 6;
            this.BtnRequest.Text = "Borrow Requests";
            this.BtnRequest.UseVisualStyleBackColor = true;
            this.BtnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(10, 987);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(334, 107);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(10, 361);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(5);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(334, 107);
            this.BtnReport.TabIndex = 5;
            this.BtnReport.Text = "Reports";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.Location = new System.Drawing.Point(10, 244);
            this.BtnUsers.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(334, 107);
            this.BtnUsers.TabIndex = 4;
            this.BtnUsers.Text = "Users";
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnBooks
            // 
            this.BtnBooks.Location = new System.Drawing.Point(10, 127);
            this.BtnBooks.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(334, 107);
            this.BtnBooks.TabIndex = 3;
            this.BtnBooks.Text = "Books";
            this.BtnBooks.UseVisualStyleBackColor = true;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Location = new System.Drawing.Point(10, 10);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(334, 107);
            this.BtnDashboard.TabIndex = 2;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UControlReport);
            this.panel3.Controls.Add(this.UControlProcessStudent);
            this.panel3.Controls.Add(this.UControlBookTransaction);
            this.panel3.Controls.Add(this.UControlHome);
            this.panel3.Controls.Add(this.UControlBooks);
            this.panel3.Controls.Add(this.UControlUsers);
            this.panel3.Controls.Add(this.UControlBookCategories);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(354, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2150, 1104);
            this.panel3.TabIndex = 2;
            // 
            // UControlReport
            // 
            this.UControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlReport.Location = new System.Drawing.Point(0, 0);
            this.UControlReport.Name = "UControlReport";
            this.UControlReport.Size = new System.Drawing.Size(2150, 1104);
            this.UControlReport.TabIndex = 6;
            this.UControlReport.Load += new System.EventHandler(this.UControlReport_Load);
            // 
            // UControlProcessStudent
            // 
            this.UControlProcessStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlProcessStudent.Location = new System.Drawing.Point(0, 0);
            this.UControlProcessStudent.Name = "UControlProcessStudent";
            this.UControlProcessStudent.Size = new System.Drawing.Size(2150, 1104);
            this.UControlProcessStudent.TabIndex = 5;
            // 
            // UControlBookTransaction
            // 
            this.UControlBookTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlBookTransaction.Location = new System.Drawing.Point(0, 0);
            this.UControlBookTransaction.Name = "UControlBookTransaction";
            this.UControlBookTransaction.Size = new System.Drawing.Size(2150, 1104);
            this.UControlBookTransaction.TabIndex = 4;
            // 
            // UControlHome
            // 
            this.UControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlHome.Location = new System.Drawing.Point(0, 0);
            this.UControlHome.Name = "UControlHome";
            this.UControlHome.Size = new System.Drawing.Size(2150, 1104);
            this.UControlHome.TabIndex = 3;
            // 
            // UControlBooks
            // 
            this.UControlBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlBooks.Location = new System.Drawing.Point(0, 0);
            this.UControlBooks.Name = "UControlBooks";
            this.UControlBooks.Size = new System.Drawing.Size(2150, 1104);
            this.UControlBooks.TabIndex = 2;
            // 
            // UControlUsers
            // 
            this.UControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlUsers.Location = new System.Drawing.Point(0, 0);
            this.UControlUsers.Name = "UControlUsers";
            this.UControlUsers.Size = new System.Drawing.Size(2150, 1104);
            this.UControlUsers.TabIndex = 1;
            // 
            // UControlBookCategories
            // 
            this.UControlBookCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UControlBookCategories.Location = new System.Drawing.Point(0, 0);
            this.UControlBookCategories.Name = "UControlBookCategories";
            this.UControlBookCategories.Size = new System.Drawing.Size(2150, 1104);
            this.UControlBookCategories.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2504, 1204);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private ReportDashboard UControlReport;
    }
}