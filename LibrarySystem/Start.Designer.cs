
namespace LibrarySystem
{
    partial class Start
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
            this.btnKiosk = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKiosk
            // 
            this.btnKiosk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKiosk.Location = new System.Drawing.Point(0, 0);
            this.btnKiosk.Name = "btnKiosk";
            this.btnKiosk.Size = new System.Drawing.Size(800, 113);
            this.btnKiosk.TabIndex = 0;
            this.btnKiosk.Text = "Kiosk";
            this.btnKiosk.UseVisualStyleBackColor = true;
            this.btnKiosk.Click += new System.EventHandler(this.btnKiosk_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.Location = new System.Drawing.Point(0, 113);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(800, 113);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 230);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnKiosk);
            this.Name = "Start";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiosk;
        private System.Windows.Forms.Button btnAdmin;
    }
}

