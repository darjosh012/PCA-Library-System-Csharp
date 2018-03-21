namespace Library_System
{
    partial class Penalties
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
            this.dataGridPenalty = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picReturnPenalty = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenalty)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturnPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPenalty
            // 
            this.dataGridPenalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPenalty.Location = new System.Drawing.Point(6, 19);
            this.dataGridPenalty.MultiSelect = false;
            this.dataGridPenalty.Name = "dataGridPenalty";
            this.dataGridPenalty.Size = new System.Drawing.Size(468, 358);
            this.dataGridPenalty.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridPenalty);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(164, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 385);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Penalty:";
            // 
            // picReturnPenalty
            // 
            this.picReturnPenalty.BackColor = System.Drawing.Color.Transparent;
            this.picReturnPenalty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picReturnPenalty.Image = global::Library_System.Properties.Resources.donor_pay;
            this.picReturnPenalty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picReturnPenalty.Location = new System.Drawing.Point(6, 19);
            this.picReturnPenalty.Name = "picReturnPenalty";
            this.picReturnPenalty.Size = new System.Drawing.Size(70, 65);
            this.picReturnPenalty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReturnPenalty.TabIndex = 9;
            this.picReturnPenalty.TabStop = false;
            this.picReturnPenalty.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::Library_System.Properties.Resources.ic_close_48px_128;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picExit.Location = new System.Drawing.Point(629, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 25);
            this.picExit.TabIndex = 20;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.picReturnPenalty);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 94);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation:";
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_System.Properties.Resources._754606_blue_solid_color_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Penalties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penalties";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenalty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReturnPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPenalty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picReturnPenalty;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}