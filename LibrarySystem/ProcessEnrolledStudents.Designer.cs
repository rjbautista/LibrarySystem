
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
            this.TxtUsnNumber.Location = new System.Drawing.Point(13, 28);
            this.TxtUsnNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsnNumber.Name = "TxtUsnNumber";
            this.TxtUsnNumber.Size = new System.Drawing.Size(447, 131);
            this.TxtUsnNumber.TabIndex = 0;
            this.TxtUsnNumber.Text = "";
            // 
            // BtnProcess
            // 
            this.BtnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(21)))));
            this.BtnProcess.FlatAppearance.BorderSize = 0;
            this.BtnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcess.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcess.ForeColor = System.Drawing.Color.White;
            this.BtnProcess.Location = new System.Drawing.Point(322, 211);
            this.BtnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(138, 37);
            this.BtnProcess.TabIndex = 1;
            this.BtnProcess.Text = "Start Process";
            this.BtnProcess.UseVisualStyleBackColor = false;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter comma separated USN numbers";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note: This process will set all students as non-enrollee. If the student USN is a" +
    "vailable this will tag the student as enrolled.";
            // 
            // TxtLog
            // 
            this.TxtLog.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLog.Location = new System.Drawing.Point(13, 319);
            this.TxtLog.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.Size = new System.Drawing.Size(447, 131);
            this.TxtLog.TabIndex = 4;
            this.TxtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Execution log:";
            // 
            // ProcessEnrolledStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.TxtUsnNumber);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcessEnrolledStudents";
            this.Size = new System.Drawing.Size(473, 466);
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
