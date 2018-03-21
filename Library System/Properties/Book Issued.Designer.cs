namespace Library_System.Properties
{
    partial class Book_Issued
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Issued));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridIssued = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIssued)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Library_System.Properties.Resources.search_2_512;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(605, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 31);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearchBox.Location = new System.Drawing.Point(435, 56);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(164, 20);
            this.txtSearchBox.TabIndex = 18;
            this.txtSearchBox.Text = "Search Book Issued";
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // picRefresh
            // 
            this.picRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picRefresh.BackgroundImage = global::Library_System.Properties.Resources.refresh;
            this.picRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picRefresh.Location = new System.Drawing.Point(622, 96);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(54, 52);
            this.picRefresh.TabIndex = 16;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridIssued);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 432);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Books Issued:";
            // 
            // dataGridIssued
            // 
            this.dataGridIssued.AllowUserToAddRows = false;
            this.dataGridIssued.AllowUserToDeleteRows = false;
            this.dataGridIssued.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridIssued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIssued.Location = new System.Drawing.Point(6, 21);
            this.dataGridIssued.Name = "dataGridIssued";
            this.dataGridIssued.ReadOnly = true;
            this.dataGridIssued.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIssued.Size = new System.Drawing.Size(601, 405);
            this.dataGridIssued.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.picReturn);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(82, 81);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Returm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picReturn
            // 
            this.picReturn.BackColor = System.Drawing.Color.Transparent;
            this.picReturn.BackgroundImage = global::Library_System.Properties.Resources.add_2_512;
            this.picReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picReturn.Image = global::Library_System.Properties.Resources._return;
            this.picReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picReturn.Location = new System.Drawing.Point(6, 12);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(70, 65);
            this.picReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReturn.TabIndex = 6;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::Library_System.Properties.Resources.ic_close_48px_128;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picExit.Location = new System.Drawing.Point(650, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 25);
            this.picExit.TabIndex = 21;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // Book_Issued
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_System.Properties.Resources._754606_blue_solid_color_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 523);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book_Issued";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Issued";
            this.Load += new System.EventHandler(this.Book_Issued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIssued)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridIssued;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picReturn;
    }
}