
namespace LibrarySystem
{
    partial class Books
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.GrpNewForm = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEdition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GridBooks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GrpNewForm.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnView);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnEdit);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1914, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Books";
            // 
            // BtnView
            // 
            this.BtnView.Enabled = false;
            this.BtnView.Location = new System.Drawing.Point(433, 43);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(205, 59);
            this.BtnView.TabIndex = 4;
            this.BtnView.Text = "Book Details";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(644, 43);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(205, 59);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Remove";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(222, 43);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(205, 59);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(11, 43);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(205, 59);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // GrpNewForm
            // 
            this.GrpNewForm.Controls.Add(this.flowLayoutPanel1);
            this.GrpNewForm.Controls.Add(this.flowLayoutPanel2);
            this.GrpNewForm.Location = new System.Drawing.Point(11, 124);
            this.GrpNewForm.Name = "GrpNewForm";
            this.GrpNewForm.Size = new System.Drawing.Size(848, 534);
            this.GrpNewForm.TabIndex = 6;
            this.GrpNewForm.TabStop = false;
            this.GrpNewForm.Text = "Book Information";
            this.GrpNewForm.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TxtTitle);
            this.flowLayoutPanel1.Controls.Add(this.ISBN);
            this.flowLayoutPanel1.Controls.Add(this.TxtIsbn);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.TxtAuthor);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.TxtEdition);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.TxtPublisher);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.CmbCategory);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.TxtYear);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.CmbStatus);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtQty);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(842, 438);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(305, 13);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(512, 31);
            this.TxtTitle.TabIndex = 1;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(13, 47);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(286, 37);
            this.ISBN.TabIndex = 7;
            this.ISBN.Text = "ISBN";
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(305, 50);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(512, 31);
            this.TxtIsbn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Author";
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(305, 87);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(512, 31);
            this.TxtAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "Edition";
            // 
            // TxtEdition
            // 
            this.TxtEdition.Location = new System.Drawing.Point(305, 124);
            this.TxtEdition.Name = "TxtEdition";
            this.TxtEdition.Size = new System.Drawing.Size(512, 31);
            this.TxtEdition.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Publisher";
            // 
            // TxtPublisher
            // 
            this.TxtPublisher.Location = new System.Drawing.Point(305, 161);
            this.TxtPublisher.Name = "TxtPublisher";
            this.TxtPublisher.Size = new System.Drawing.Size(512, 31);
            this.TxtPublisher.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Category";
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(305, 198);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(512, 33);
            this.CmbCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Publication Year";
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(305, 237);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(512, 31);
            this.TxtYear.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(13, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 36);
            this.label12.TabIndex = 27;
            this.label12.Text = "Status";
            // 
            // CmbStatus
            // 
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "active",
            "withdrawn",
            "deactivated"});
            this.CmbStatus.Location = new System.Drawing.Point(305, 274);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(512, 33);
            this.CmbStatus.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 37);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(305, 313);
            this.txtQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(512, 31);
            this.txtQty.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BtnSave);
            this.flowLayoutPanel2.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 465);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(842, 66);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(205, 59);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(214, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(205, 59);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Close";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GridBooks
            // 
            this.GridBooks.AllowUserToAddRows = false;
            this.GridBooks.AllowUserToDeleteRows = false;
            this.GridBooks.AllowUserToResizeRows = false;
            this.GridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.GridBooks.Location = new System.Drawing.Point(0, 108);
            this.GridBooks.MultiSelect = false;
            this.GridBooks.Name = "GridBooks";
            this.GridBooks.ReadOnly = true;
            this.GridBooks.RowHeadersWidth = 82;
            this.GridBooks.RowTemplate.Height = 33;
            this.GridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBooks.Size = new System.Drawing.Size(1914, 998);
            this.GridBooks.TabIndex = 1;
            this.GridBooks.SelectionChanged += new System.EventHandler(this.GridBookCategory_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 980);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1914, 126);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbFilter);
            this.groupBox3.Controls.Add(this.TxtSearch);
            this.groupBox3.Controls.Add(this.BtnSearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1264, 126);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // CmbFilter
            // 
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Title",
            "Author",
            "ISBN",
            "Publisher"});
            this.CmbFilter.Location = new System.Drawing.Point(599, 41);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(355, 33);
            this.CmbFilter.TabIndex = 7;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(6, 43);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(587, 31);
            this.TxtSearch.TabIndex = 4;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(960, 35);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(239, 47);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrpNewForm);
            this.Controls.Add(this.GridBooks);
            this.Controls.Add(this.groupBox1);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(1914, 1106);
            this.Load += new System.EventHandler(this.Books_Load);
            this.groupBox1.ResumeLayout(false);
            this.GrpNewForm.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridBooks;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.GroupBox GrpNewForm;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEdition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Button BtnView;
    }
}
