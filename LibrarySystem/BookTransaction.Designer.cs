
namespace LibrarySystem
{
    partial class BookTransaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnView = new System.Windows.Forms.Button();
            this.LblTransaction = new System.Windows.Forms.Label();
            this.LblBookTransaction = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridTransactions = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 78);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.BtnView);
            this.panel3.Controls.Add(this.LblTransaction);
            this.panel3.Controls.Add(this.LblBookTransaction);
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.TxtSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(615, 78);
            this.panel3.TabIndex = 0;
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(21)))));
            this.BtnView.FlatAppearance.BorderSize = 0;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(407, 45);
            this.BtnView.Margin = new System.Windows.Forms.Padding(2);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(196, 27);
            this.BtnView.TabIndex = 0;
            this.BtnView.Text = "View Transaction Details";
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // LblTransaction
            // 
            this.LblTransaction.AutoSize = true;
            this.LblTransaction.Location = new System.Drawing.Point(2, 0);
            this.LblTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTransaction.Name = "LblTransaction";
            this.LblTransaction.Size = new System.Drawing.Size(47, 13);
            this.LblTransaction.TabIndex = 4;
            this.LblTransaction.Text = "Request";
            this.LblTransaction.Visible = false;
            // 
            // LblBookTransaction
            // 
            this.LblBookTransaction.AutoSize = true;
            this.LblBookTransaction.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookTransaction.ForeColor = System.Drawing.Color.White;
            this.LblBookTransaction.Location = new System.Drawing.Point(17, 17);
            this.LblBookTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBookTransaction.Name = "LblBookTransaction";
            this.LblBookTransaction.Size = new System.Drawing.Size(162, 20);
            this.LblBookTransaction.TabIndex = 3;
            this.LblBookTransaction.Text = "Borrow Requests";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(21)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(291, 45);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(112, 27);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(89, 48);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(198, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GridTransactions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 467);
            this.panel2.TabIndex = 3;
            // 
            // GridTransactions
            // 
            this.GridTransactions.AllowUserToAddRows = false;
            this.GridTransactions.AllowUserToDeleteRows = false;
            this.GridTransactions.BackgroundColor = System.Drawing.Color.White;
            this.GridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTransactions.Location = new System.Drawing.Point(0, 0);
            this.GridTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.GridTransactions.MinimumSize = new System.Drawing.Size(150, 0);
            this.GridTransactions.MultiSelect = false;
            this.GridTransactions.Name = "GridTransactions";
            this.GridTransactions.ReadOnly = true;
            this.GridTransactions.RowHeadersWidth = 82;
            this.GridTransactions.RowTemplate.Height = 33;
            this.GridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTransactions.Size = new System.Drawing.Size(828, 467);
            this.GridTransactions.TabIndex = 3;
            this.GridTransactions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTransactions_CellDoubleClick);
            // 
            // BookTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookTransaction";
            this.Size = new System.Drawing.Size(828, 545);
            this.Load += new System.EventHandler(this.BookTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridTransactions;
        private System.Windows.Forms.Label LblBookTransaction;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Label LblTransaction;
    }
}
