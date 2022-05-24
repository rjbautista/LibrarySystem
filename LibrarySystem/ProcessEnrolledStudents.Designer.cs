
namespace LibrarySystem
{
    partial class ProcessEnrolledStudents
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
            this.TxtUsnNumber = new System.Windows.Forms.RichTextBox();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUsnNumber
            // 
            this.TxtUsnNumber.Location = new System.Drawing.Point(26, 54);
            this.TxtUsnNumber.Name = "TxtUsnNumber";
            this.TxtUsnNumber.Size = new System.Drawing.Size(838, 248);
            this.TxtUsnNumber.TabIndex = 0;
            this.TxtUsnNumber.Text = "";
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(588, 387);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(276, 52);
            this.BtnProcess.TabIndex = 1;
            this.BtnProcess.Text = "Start Process";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter comma separated USN numbers";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(843, 68);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note: This process will set all students as non-enrollee. If the student USN is a" +
    "vailable this will tag the student as enrolled.";
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(26, 493);
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.Size = new System.Drawing.Size(838, 248);
            this.TxtLog.TabIndex = 4;
            this.TxtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Execution log:";
            // 
            // ProcessEnrolledStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.TxtUsnNumber);
            this.Name = "ProcessEnrolledStudents";
            this.Size = new System.Drawing.Size(902, 766);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtUsnNumber;
        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TxtLog;
        private System.Windows.Forms.Label label3;
    }
}
