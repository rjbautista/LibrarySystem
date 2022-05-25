
namespace LibrarySystem
{
    partial class PrintReport
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
            this.GrpBookTitle = new System.Windows.Forms.GroupBox();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GrpBookTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBookTitle
            // 
            this.GrpBookTitle.Controls.Add(this.CmbFilter);
            this.GrpBookTitle.Controls.Add(this.BtnSearch);
            this.GrpBookTitle.Controls.Add(this.label1);
            this.GrpBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpBookTitle.Location = new System.Drawing.Point(0, 0);
            this.GrpBookTitle.Name = "GrpBookTitle";
            this.GrpBookTitle.Size = new System.Drawing.Size(1824, 130);
            this.GrpBookTitle.TabIndex = 0;
            this.GrpBookTitle.TabStop = false;
            this.GrpBookTitle.Text = "Filter";
            // 
            // CmbFilter
            // 
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(155, 51);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(562, 33);
            this.CmbFilter.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(723, 45);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(152, 42);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Refresh";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book name";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibrarySystem.Reports.RptBooks.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 130);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1824, 998);
            this.reportViewer1.TabIndex = 1;
            // 
            // PrintReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1128);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.GrpBookTitle);
            this.Name = "PrintReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.GrpBookTitle.ResumeLayout(false);
            this.GrpBookTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBookTitle;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
    }
}