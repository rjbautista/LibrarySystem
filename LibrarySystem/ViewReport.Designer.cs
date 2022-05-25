
namespace LibrarySystem
{
    partial class ViewReport
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
            this.GridTransactions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnView = new System.Windows.Forms.Button();
            this.LblTransaction = new System.Windows.Forms.Label();
            this.LblBookTransaction = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridTransactions)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridTransactions
            // 
            this.GridTransactions.AllowUserToAddRows = false;
            this.GridTransactions.AllowUserToDeleteRows = false;
            this.GridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTransactions.Location = new System.Drawing.Point(0, 78);
            this.GridTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.GridTransactions.MinimumSize = new System.Drawing.Size(150, 0);
            this.GridTransactions.MultiSelect = false;
            this.GridTransactions.Name = "GridTransactions";
            this.GridTransactions.ReadOnly = true;
            this.GridTransactions.RowHeadersWidth = 82;
            this.GridTransactions.RowTemplate.Height = 33;
            this.GridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTransactions.Size = new System.Drawing.Size(828, 467);
            this.GridTransactions.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 78);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CmbFilter);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.BtnView);
            this.panel3.Controls.Add(this.LblTransaction);
            this.panel3.Controls.Add(this.LblBookTransaction);
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(654, 78);
            this.panel3.TabIndex = 0;
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(496, 41);
            this.BtnView.Margin = new System.Windows.Forms.Padding(2);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(146, 25);
            this.BtnView.TabIndex = 0;
            this.BtnView.Text = "Print Report";
            this.BtnView.UseVisualStyleBackColor = true;
            // 
            // LblTransaction
            // 
            this.LblTransaction.AutoSize = true;
            this.LblTransaction.Location = new System.Drawing.Point(2, 0);
            this.LblTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTransaction.Name = "LblTransaction";
            this.LblTransaction.Size = new System.Drawing.Size(44, 13);
            this.LblTransaction.TabIndex = 4;
            this.LblTransaction.Text = "Reports";
            this.LblTransaction.Visible = false;
            // 
            // LblBookTransaction
            // 
            this.LblBookTransaction.AutoSize = true;
            this.LblBookTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookTransaction.Location = new System.Drawing.Point(17, 17);
            this.LblBookTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBookTransaction.Name = "LblBookTransaction";
            this.LblBookTransaction.Size = new System.Drawing.Size(73, 20);
            this.LblBookTransaction.TabIndex = 3;
            this.LblBookTransaction.Text = "Reports";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSearch.Location = new System.Drawing.Point(398, 42);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 25);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(153, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CmbFilter
            // 
            this.CmbFilter.BackColor = System.Drawing.Color.White;
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Users",
            "Books logs",
            "Incident Report"});
            this.CmbFilter.Location = new System.Drawing.Point(202, 41);
            this.CmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(192, 24);
            this.CmbFilter.TabIndex = 6;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridTransactions);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewReport";
            this.Size = new System.Drawing.Size(828, 545);
            this.Load += new System.EventHandler(this.ViewReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTransactions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridTransactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Label LblTransaction;
        private System.Windows.Forms.Label LblBookTransaction;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbFilter;
    }
}
