
namespace LibrarySystem
{
    partial class PrintBookTxn
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
            this.cmbFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GrpBookTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBookTitle
            // 
            this.GrpBookTitle.Controls.Add(this.label3);
            this.GrpBookTitle.Controls.Add(this.cmbTo);
            this.GrpBookTitle.Controls.Add(this.label2);
            this.GrpBookTitle.Controls.Add(this.cmbFrom);
            this.GrpBookTitle.Controls.Add(this.CmbFilter);
            this.GrpBookTitle.Controls.Add(this.BtnSearch);
            this.GrpBookTitle.Controls.Add(this.label1);
            this.GrpBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpBookTitle.Location = new System.Drawing.Point(0, 0);
            this.GrpBookTitle.Name = "GrpBookTitle";
            this.GrpBookTitle.Size = new System.Drawing.Size(2318, 130);
            this.GrpBookTitle.TabIndex = 2;
            this.GrpBookTitle.TabStop = false;
            this.GrpBookTitle.Text = "Filter";
            // 
            // CmbFilter
            // 
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Request",
            "Borrowed",
            "Returned",
            "Declined"});
            this.CmbFilter.Location = new System.Drawing.Point(214, 51);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(282, 33);
            this.CmbFilter.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1168, 47);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(152, 42);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Refresh";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Type";
            // 
            // cmbFrom
            // 
            this.cmbFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbFrom.Location = new System.Drawing.Point(648, 51);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(204, 31);
            this.cmbFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(868, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date To";
            // 
            // cmbTo
            // 
            this.cmbTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbTo.Location = new System.Drawing.Point(962, 51);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(200, 31);
            this.cmbTo.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibrarySystem.Reports.RptBooks.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 130);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(2318, 1044);
            this.reportViewer1.TabIndex = 4;
            // 
            // PrintBookTxn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2318, 1174);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.GrpBookTitle);
            this.Name = "PrintBookTxn";
            this.Text = "PrintBookTxn";
            this.Load += new System.EventHandler(this.PrintBookTxn_Load);
            this.GrpBookTitle.ResumeLayout(false);
            this.GrpBookTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBookTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker cmbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cmbFrom;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}