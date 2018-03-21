namespace Library_System
{
    partial class Main_Window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.dataGrid_BookList = new System.Windows.Forms.DataGridView();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBorrow = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picExit = new System.Windows.Forms.PictureBox();
            this.cbxClassification = new System.Windows.Forms.ComboBox();
            this.pcalibrary_databaseDataSet = new Library_System.pcalibrary_databaseDataSet();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library_System.pcalibrary_databaseDataSetTableAdapters.booksTableAdapter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_BookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcalibrary_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_BookList
            // 
            this.dataGrid_BookList.AllowUserToAddRows = false;
            this.dataGrid_BookList.AllowUserToDeleteRows = false;
            this.dataGrid_BookList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGrid_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGrid_BookList, "dataGrid_BookList");
            this.dataGrid_BookList.MultiSelect = false;
            this.dataGrid_BookList.Name = "dataGrid_BookList";
            this.dataGrid_BookList.ReadOnly = true;
            this.dataGrid_BookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_BookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.Color.Transparent;
            this.picDelete.BackgroundImage = global::Library_System.Properties.Resources.trash_2_512;
            resources.ApplyResources(this.picDelete, "picDelete");
            this.picDelete.Name = "picDelete";
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.Transparent;
            this.picEdit.BackgroundImage = global::Library_System.Properties.Resources.write_2_512;
            resources.ApplyResources(this.picEdit, "picEdit");
            this.picEdit.Name = "picEdit";
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picRefresh.BackgroundImage = global::Library_System.Properties.Resources.refresh;
            resources.ApplyResources(this.picRefresh, "picRefresh");
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGrid_BookList);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.picBorrow);
            this.groupBox2.Controls.Add(this.picAdd);
            this.groupBox2.Controls.Add(this.picDelete);
            this.groupBox2.Controls.Add(this.picEdit);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Name = "label1";
            // 
            // picBorrow
            // 
            this.picBorrow.BackColor = System.Drawing.Color.Transparent;
            this.picBorrow.BackgroundImage = global::Library_System.Properties.Resources.search_2_512;
            resources.ApplyResources(this.picBorrow, "picBorrow");
            this.picBorrow.Image = global::Library_System.Properties.Resources.borrow;
            this.picBorrow.Name = "picBorrow";
            this.picBorrow.TabStop = false;
            this.picBorrow.Click += new System.EventHandler(this.picBorrow_Click);
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.BackgroundImage = global::Library_System.Properties.Resources.add_2_512;
            resources.ApplyResources(this.picAdd, "picAdd");
            this.picAdd.Name = "picAdd";
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // txtSearchBox
            // 
            resources.ApplyResources(this.txtSearchBox, "txtSearchBox");
            this.txtSearchBox.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Library_System.Properties.Resources.search_2_512;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::Library_System.Properties.Resources.ic_close_48px_128;
            resources.ApplyResources(this.picExit, "picExit");
            this.picExit.Name = "picExit";
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbxClassification
            // 
            this.cbxClassification.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cbxClassification.AutoCompleteCustomSource"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource1"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource2"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource3"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource4"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource5"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource6"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource7"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource8"),
            resources.GetString("cbxClassification.AutoCompleteCustomSource9")});
            this.cbxClassification.FormattingEnabled = true;
            this.cbxClassification.Items.AddRange(new object[] {
            resources.GetString("cbxClassification.Items"),
            resources.GetString("cbxClassification.Items1"),
            resources.GetString("cbxClassification.Items2"),
            resources.GetString("cbxClassification.Items3"),
            resources.GetString("cbxClassification.Items4"),
            resources.GetString("cbxClassification.Items5"),
            resources.GetString("cbxClassification.Items6"),
            resources.GetString("cbxClassification.Items7"),
            resources.GetString("cbxClassification.Items8"),
            resources.GetString("cbxClassification.Items9"),
            resources.GetString("cbxClassification.Items10"),
            resources.GetString("cbxClassification.Items11")});
            resources.ApplyResources(this.cbxClassification, "cbxClassification");
            this.cbxClassification.Name = "cbxClassification";
            // 
            // pcalibrary_databaseDataSet
            // 
            this.pcalibrary_databaseDataSet.DataSetName = "pcalibrary_databaseDataSet";
            this.pcalibrary_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "books";
            this.booksBindingSource1.DataSource = this.pcalibrary_databaseDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Main_Window
            // 
            this.AcceptButton = this.btnSearch;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Library_System.Properties.Resources._754606_blue_solid_color_wallpaper;
            this.ControlBox = false;
            this.Controls.Add(this.cbxClassification);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_BookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcalibrary_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_BookList;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBorrow;
        private System.Windows.Forms.ComboBox cbxClassification;
        private pcalibrary_databaseDataSet pcalibrary_databaseDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private pcalibrary_databaseDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}