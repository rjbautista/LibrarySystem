
namespace LibrarySystem
{
    partial class IRForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblIrNumber = new System.Windows.Forms.Label();
            this.TxtDetails = new System.Windows.Forms.RichTextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblUsn = new System.Windows.Forms.Label();
            this.LblCourse = new System.Windows.Forms.Label();
            this.LblTxnNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblStudentId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTxnHeaderId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incident Report";
            // 
            // LblIrNumber
            // 
            this.LblIrNumber.AutoSize = true;
            this.LblIrNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIrNumber.Location = new System.Drawing.Point(232, 18);
            this.LblIrNumber.Name = "LblIrNumber";
            this.LblIrNumber.Size = new System.Drawing.Size(46, 31);
            this.LblIrNumber.TabIndex = 1;
            this.LblIrNumber.Text = "##";
            // 
            // TxtDetails
            // 
            this.TxtDetails.Location = new System.Drawing.Point(12, 372);
            this.TxtDetails.Name = "TxtDetails";
            this.TxtDetails.Size = new System.Drawing.Size(776, 280);
            this.TxtDetails.TabIndex = 2;
            this.TxtDetails.Text = "";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(432, 665);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(167, 47);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(605, 665);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(167, 47);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Incident details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Borrower Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "USN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Course:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(173, 70);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 25);
            this.LblName.TabIndex = 9;
            this.LblName.Text = "label6";
            // 
            // LblUsn
            // 
            this.LblUsn.AutoSize = true;
            this.LblUsn.Location = new System.Drawing.Point(65, 105);
            this.LblUsn.Name = "LblUsn";
            this.LblUsn.Size = new System.Drawing.Size(70, 25);
            this.LblUsn.TabIndex = 10;
            this.LblUsn.Text = "label7";
            // 
            // LblCourse
            // 
            this.LblCourse.AutoSize = true;
            this.LblCourse.Location = new System.Drawing.Point(96, 142);
            this.LblCourse.Name = "LblCourse";
            this.LblCourse.Size = new System.Drawing.Size(70, 25);
            this.LblCourse.TabIndex = 11;
            this.LblCourse.Text = "label8";
            // 
            // LblTxnNo
            // 
            this.LblTxnNo.AutoSize = true;
            this.LblTxnNo.Location = new System.Drawing.Point(125, 176);
            this.LblTxnNo.Name = "LblTxnNo";
            this.LblTxnNo.Size = new System.Drawing.Size(70, 25);
            this.LblTxnNo.TabIndex = 13;
            this.LblTxnNo.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Request #: ";
            // 
            // LblStudentId
            // 
            this.LblStudentId.AutoSize = true;
            this.LblStudentId.Location = new System.Drawing.Point(13, 214);
            this.LblStudentId.Name = "LblStudentId";
            this.LblStudentId.Size = new System.Drawing.Size(109, 25);
            this.LblStudentId.TabIndex = 14;
            this.LblStudentId.Text = "Student Id";
            this.LblStudentId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Title";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(12, 296);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.ReadOnly = true;
            this.TxtTitle.Size = new System.Drawing.Size(776, 31);
            this.TxtTitle.TabIndex = 16;
            // 
            // LblTxnHeaderId
            // 
            this.LblTxnHeaderId.AutoSize = true;
            this.LblTxnHeaderId.Location = new System.Drawing.Point(17, 239);
            this.LblTxnHeaderId.Name = "LblTxnHeaderId";
            this.LblTxnHeaderId.Size = new System.Drawing.Size(129, 25);
            this.LblTxnHeaderId.TabIndex = 17;
            this.LblTxnHeaderId.Text = "TxtHeaderId";
            this.LblTxnHeaderId.Visible = false;
            // 
            // IRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.LblTxnHeaderId);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblStudentId);
            this.Controls.Add(this.LblTxnNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblCourse);
            this.Controls.Add(this.LblUsn);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDetails);
            this.Controls.Add(this.LblIrNumber);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "IRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IRForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.IRForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIrNumber;
        private System.Windows.Forms.RichTextBox TxtDetails;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblUsn;
        private System.Windows.Forms.Label LblCourse;
        private System.Windows.Forms.Label LblTxnNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblStudentId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblTxnHeaderId;
    }
}