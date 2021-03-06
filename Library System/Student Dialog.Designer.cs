﻿namespace Library_System
{
    partial class Student_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Dialog));
            this.dataGrid_StudentList = new System.Windows.Forms.DataGridView();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_StudentList
            // 
            this.dataGrid_StudentList.AllowUserToAddRows = false;
            this.dataGrid_StudentList.AllowUserToDeleteRows = false;
            this.dataGrid_StudentList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGrid_StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_StudentList.Location = new System.Drawing.Point(6, 21);
            this.dataGrid_StudentList.MultiSelect = false;
            this.dataGrid_StudentList.Name = "dataGrid_StudentList";
            this.dataGrid_StudentList.ReadOnly = true;
            this.dataGrid_StudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_StudentList.Size = new System.Drawing.Size(601, 405);
            this.dataGrid_StudentList.TabIndex = 0;
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.Color.Transparent;
            this.picDelete.BackgroundImage = global::Library_System.Properties.Resources.trash_2_512;
            this.picDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picDelete.Location = new System.Drawing.Point(82, 10);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(70, 65);
            this.picDelete.TabIndex = 6;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.Transparent;
            this.picEdit.BackgroundImage = global::Library_System.Properties.Resources.write_2_512;
            this.picEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picEdit.Location = new System.Drawing.Point(158, 10);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(70, 65);
            this.picEdit.TabIndex = 8;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.picAdd);
            this.groupBox2.Controls.Add(this.picDelete);
            this.groupBox2.Controls.Add(this.picEdit);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 81);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.BackgroundImage = global::Library_System.Properties.Resources.add_2_512;
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picAdd.Location = new System.Drawing.Point(6, 10);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(70, 65);
            this.picAdd.TabIndex = 5;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picRefresh.BackgroundImage = global::Library_System.Properties.Resources.refresh;
            this.picRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picRefresh.Location = new System.Drawing.Point(622, 100);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(54, 52);
            this.picRefresh.TabIndex = 17;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGrid_StudentList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(6, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 432);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Students:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Library_System.Properties.Resources.search_2_512;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(608, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 31);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearchBox.Location = new System.Drawing.Point(438, 56);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(164, 20);
            this.txtSearchBox.TabIndex = 20;
            this.txtSearchBox.Text = "Search Students";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::Library_System.Properties.Resources.ic_close_48px_128;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picExit.Location = new System.Drawing.Point(650, -2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 25);
            this.picExit.TabIndex = 22;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // Student_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_System.Properties.Resources._754606_blue_solid_color_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.picExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_StudentList;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox picExit;
    }
}