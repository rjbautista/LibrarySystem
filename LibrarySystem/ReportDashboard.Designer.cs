
namespace LibrarySystem
{
    partial class ReportDashboard
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
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnBookDetail = new System.Windows.Forms.Button();
            this.BtnBookTxn = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBook
            // 
            this.BtnBook.Location = new System.Drawing.Point(20, 22);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(294, 98);
            this.BtnBook.TabIndex = 0;
            this.BtnBook.Text = "Books";
            this.BtnBook.UseVisualStyleBackColor = true;
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // BtnBookDetail
            // 
            this.BtnBookDetail.Location = new System.Drawing.Point(20, 126);
            this.BtnBookDetail.Name = "BtnBookDetail";
            this.BtnBookDetail.Size = new System.Drawing.Size(294, 98);
            this.BtnBookDetail.TabIndex = 1;
            this.BtnBookDetail.Text = "Book Detail";
            this.BtnBookDetail.UseVisualStyleBackColor = true;
            this.BtnBookDetail.Click += new System.EventHandler(this.BtnBookDetail_Click);
            // 
            // BtnBookTxn
            // 
            this.BtnBookTxn.Location = new System.Drawing.Point(20, 230);
            this.BtnBookTxn.Name = "BtnBookTxn";
            this.BtnBookTxn.Size = new System.Drawing.Size(294, 98);
            this.BtnBookTxn.TabIndex = 2;
            this.BtnBookTxn.Text = "Book Transaction";
            this.BtnBookTxn.UseVisualStyleBackColor = true;
            this.BtnBookTxn.Click += new System.EventHandler(this.BtnBookTxn_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(20, 334);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(294, 98);
            this.BtnUser.TabIndex = 3;
            this.BtnUser.Text = "Users";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // ReportDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.BtnBookTxn);
            this.Controls.Add(this.BtnBookDetail);
            this.Controls.Add(this.BtnBook);
            this.Name = "ReportDashboard";
            this.Size = new System.Drawing.Size(1004, 766);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnBookDetail;
        private System.Windows.Forms.Button BtnBookTxn;
        private System.Windows.Forms.Button BtnUser;
    }
}
