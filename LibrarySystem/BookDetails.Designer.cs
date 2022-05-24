
namespace LibrarySystem
{
    partial class BookDetails
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
            this.LblBooktitle = new System.Windows.Forms.Label();
            this.LblBookId = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GrpNewForm = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBookNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ChkAvailable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.RichTextBox();
            this.GrpBorrowedBy = new System.Windows.Forms.GroupBox();
            this.lblBorrowedBy = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GridBooks = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.GridHistory = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.GrpNewForm.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.GrpBorrowedBy.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblBooktitle);
            this.panel1.Controls.Add(this.LblBookId);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(2130, 82);
            this.panel1.TabIndex = 0;
            // 
            // LblBooktitle
            // 
            this.LblBooktitle.AutoSize = true;
            this.LblBooktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBooktitle.Location = new System.Drawing.Point(22, 30);
            this.LblBooktitle.Name = "LblBooktitle";
            this.LblBooktitle.Size = new System.Drawing.Size(150, 31);
            this.LblBooktitle.TabIndex = 0;
            this.LblBooktitle.Text = "Book name";
            // 
            // LblBookId
            // 
            this.LblBookId.AutoSize = true;
            this.LblBookId.Location = new System.Drawing.Point(1884, 29);
            this.LblBookId.Name = "LblBookId";
            this.LblBookId.Size = new System.Drawing.Size(78, 25);
            this.LblBookId.TabIndex = 2;
            this.LblBookId.Text = "BookId";
            this.LblBookId.Visible = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.Location = new System.Drawing.Point(1975, 10);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(10);
            this.BtnClose.Size = new System.Drawing.Size(145, 62);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2130, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2130, 898);
            this.panel4.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridHistory);
            this.splitContainer1.Panel2.Controls.Add(this.panel8);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(2130, 898);
            this.splitContainer1.SplitterDistance = 1018;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.GrpNewForm);
            this.panel7.Controls.Add(this.GridBooks);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 698);
            this.panel7.TabIndex = 2;
            // 
            // GrpNewForm
            // 
            this.GrpNewForm.Controls.Add(this.flowLayoutPanel1);
            this.GrpNewForm.Controls.Add(this.flowLayoutPanel2);
            this.GrpNewForm.Location = new System.Drawing.Point(27, 6);
            this.GrpNewForm.Name = "GrpNewForm";
            this.GrpNewForm.Size = new System.Drawing.Size(848, 534);
            this.GrpNewForm.TabIndex = 7;
            this.GrpNewForm.TabStop = false;
            this.GrpNewForm.Text = "Book Information";
            this.GrpNewForm.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.TxtBookNo);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.CmbStatus);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.ChkAvailable);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.TxtNote);
            this.flowLayoutPanel1.Controls.Add(this.GrpBorrowedBy);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(842, 438);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book No";
            // 
            // TxtBookNo
            // 
            this.TxtBookNo.Location = new System.Drawing.Point(305, 13);
            this.TxtBookNo.Name = "TxtBookNo";
            this.TxtBookNo.Size = new System.Drawing.Size(512, 31);
            this.TxtBookNo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(13, 47);
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
            "borrowed",
            "deactivated",
            "withdrawn",
            "unreturned",
            "damaged"});
            this.CmbStatus.Location = new System.Drawing.Point(305, 50);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(512, 33);
            this.CmbStatus.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(13, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 36);
            this.label13.TabIndex = 37;
            this.label13.Text = "Is Available?";
            // 
            // ChkAvailable
            // 
            this.ChkAvailable.Location = new System.Drawing.Point(305, 89);
            this.ChkAvailable.Name = "ChkAvailable";
            this.ChkAvailable.Size = new System.Drawing.Size(396, 29);
            this.ChkAvailable.TabIndex = 36;
            this.ChkAvailable.Text = "Yes";
            this.ChkAvailable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 36);
            this.label3.TabIndex = 38;
            this.label3.Text = "Note";
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(305, 125);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(512, 130);
            this.TxtNote.TabIndex = 39;
            this.TxtNote.Text = "";
            // 
            // GrpBorrowedBy
            // 
            this.GrpBorrowedBy.Controls.Add(this.lblBorrowedBy);
            this.GrpBorrowedBy.Location = new System.Drawing.Point(13, 261);
            this.GrpBorrowedBy.Name = "GrpBorrowedBy";
            this.GrpBorrowedBy.Size = new System.Drawing.Size(804, 88);
            this.GrpBorrowedBy.TabIndex = 42;
            this.GrpBorrowedBy.TabStop = false;
            this.GrpBorrowedBy.Text = "Currently being borrowed by:";
            this.GrpBorrowedBy.Visible = false;
            // 
            // lblBorrowedBy
            // 
            this.lblBorrowedBy.AutoSize = true;
            this.lblBorrowedBy.Location = new System.Drawing.Point(20, 38);
            this.lblBorrowedBy.Name = "lblBorrowedBy";
            this.lblBorrowedBy.Size = new System.Drawing.Size(160, 25);
            this.lblBorrowedBy.TabIndex = 41;
            this.lblBorrowedBy.Text = "USN and Name";
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
            this.GridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBooks.Location = new System.Drawing.Point(0, 0);
            this.GridBooks.MinimumSize = new System.Drawing.Size(300, 0);
            this.GridBooks.MultiSelect = false;
            this.GridBooks.Name = "GridBooks";
            this.GridBooks.ReadOnly = true;
            this.GridBooks.RowHeadersWidth = 82;
            this.GridBooks.RowTemplate.Height = 33;
            this.GridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBooks.Size = new System.Drawing.Size(1018, 698);
            this.GridBooks.TabIndex = 0;
            this.GridBooks.SelectionChanged += new System.EventHandler(this.GridBooks_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 798);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1018, 100);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnDelete);
            this.panel5.Controls.Add(this.BtnEdit);
            this.panel5.Controls.Add(this.BtnNew);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1018, 100);
            this.panel5.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(333, 29);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(147, 43);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(180, 29);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(147, 43);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(27, 29);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(147, 43);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New Book";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // GridHistory
            // 
            this.GridHistory.AllowUserToAddRows = false;
            this.GridHistory.AllowUserToDeleteRows = false;
            this.GridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridHistory.Location = new System.Drawing.Point(0, 100);
            this.GridHistory.MinimumSize = new System.Drawing.Size(500, 0);
            this.GridHistory.Name = "GridHistory";
            this.GridHistory.ReadOnly = true;
            this.GridHistory.RowHeadersWidth = 82;
            this.GridHistory.RowTemplate.Height = 33;
            this.GridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHistory.Size = new System.Drawing.Size(1108, 698);
            this.GridHistory.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 798);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1108, 100);
            this.panel8.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 100);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1108, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2130, 1080);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.GrpNewForm.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.GrpBorrowedBy.ResumeLayout(false);
            this.GrpBorrowedBy.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBooks)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblBookId;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblBooktitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView GridBooks;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridView GridHistory;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpNewForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBookNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ChkAvailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TxtNote;
        private System.Windows.Forms.GroupBox GrpBorrowedBy;
        private System.Windows.Forms.Label lblBorrowedBy;
    }
}