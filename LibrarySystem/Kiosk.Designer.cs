
namespace LibrarySystem
{
    partial class Kiosk
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSendRequest = new System.Windows.Forms.Button();
            this.TxtUsn = new System.Windows.Forms.TextBox();
            this.BtnBorrow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.GridCart = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.GridBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCart)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2128, 198);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnSearch);
            this.panel5.Controls.Add(this.CmbFilter);
            this.panel5.Controls.Add(this.TxtSearch);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2128, 98);
            this.panel5.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(950, 30);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(153, 38);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CmbFilter
            // 
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Any",
            "Title",
            "Author",
            "Category",
            "Edition",
            "Publisher",
            "PublicationYear"});
            this.CmbFilter.Location = new System.Drawing.Point(565, 31);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(379, 33);
            this.CmbFilter.TabIndex = 3;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(98, 31);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(358, 31);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Search";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2128, 100);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(604, 100);
            this.label4.TabIndex = 1;
            this.label4.Text = "ACLC Library System Kiosk";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSendRequest);
            this.panel2.Controls.Add(this.TxtUsn);
            this.panel2.Controls.Add(this.BtnBorrow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1006);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(2128, 100);
            this.panel2.TabIndex = 1;
            // 
            // BtnSendRequest
            // 
            this.BtnSendRequest.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSendRequest.Location = new System.Drawing.Point(1644, 10);
            this.BtnSendRequest.Name = "BtnSendRequest";
            this.BtnSendRequest.Size = new System.Drawing.Size(237, 80);
            this.BtnSendRequest.TabIndex = 2;
            this.BtnSendRequest.Text = "Create Request";
            this.BtnSendRequest.UseVisualStyleBackColor = true;
            this.BtnSendRequest.Click += new System.EventHandler(this.BtnSendRequest_Click);
            // 
            // TxtUsn
            // 
            this.TxtUsn.Location = new System.Drawing.Point(1470, 35);
            this.TxtUsn.Name = "TxtUsn";
            this.TxtUsn.Size = new System.Drawing.Size(168, 31);
            this.TxtUsn.TabIndex = 1;
            // 
            // BtnBorrow
            // 
            this.BtnBorrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBorrow.Location = new System.Drawing.Point(1881, 10);
            this.BtnBorrow.Name = "BtnBorrow";
            this.BtnBorrow.Size = new System.Drawing.Size(237, 80);
            this.BtnBorrow.TabIndex = 0;
            this.BtnBorrow.Text = "Borrow";
            this.BtnBorrow.UseVisualStyleBackColor = true;
            this.BtnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2128, 808);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.Controls.Add(this.panel10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2128, 808);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.GridCart);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(1109, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1016, 802);
            this.panel10.TabIndex = 2;
            // 
            // GridCart
            // 
            this.GridCart.AllowUserToAddRows = false;
            this.GridCart.AllowUserToDeleteRows = false;
            this.GridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCart.Location = new System.Drawing.Point(0, 71);
            this.GridCart.Name = "GridCart";
            this.GridCart.ReadOnly = true;
            this.GridCart.RowHeadersWidth = 82;
            this.GridCart.RowTemplate.Height = 33;
            this.GridCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCart.Size = new System.Drawing.Size(1016, 731);
            this.GridCart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20);
            this.label3.Size = new System.Drawing.Size(1016, 71);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cart";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.GridBooks);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1015, 802);
            this.panel9.TabIndex = 1;
            // 
            // GridBooks
            // 
            this.GridBooks.AllowUserToAddRows = false;
            this.GridBooks.AllowUserToDeleteRows = false;
            this.GridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBooks.Location = new System.Drawing.Point(0, 71);
            this.GridBooks.Name = "GridBooks";
            this.GridBooks.ReadOnly = true;
            this.GridBooks.RowHeadersWidth = 82;
            this.GridBooks.RowTemplate.Height = 33;
            this.GridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBooks.Size = new System.Drawing.Size(1015, 731);
            this.GridBooks.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20);
            this.label2.Size = new System.Drawing.Size(1015, 71);
            this.label2.TabIndex = 0;
            this.label2.Text = "List of Books";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1024, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(79, 802);
            this.panel6.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnRemove, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(79, 802);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRemove.Location = new System.Drawing.Point(8, 403);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(63, 73);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "<";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Location = new System.Drawing.Point(8, 324);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(63, 73);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = ">";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Kiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2128, 1106);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Kiosk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kiosk_FormClosed);
            this.Load += new System.EventHandler(this.Kiosk_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCart)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Button BtnBorrow;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView GridCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView GridBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSendRequest;
        private System.Windows.Forms.TextBox TxtUsn;
    }
}