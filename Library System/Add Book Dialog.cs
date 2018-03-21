using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Add_Book_Dialog : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        Main_Window mainWindow = new Main_Window();


        public Add_Book_Dialog()
        {
            InitializeComponent();
            this.FormClosed += delegate {mainWindow.ShowDialog(); };
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            mcon.Open();
            string addData = "INSERT INTO books (Book_Name, Author, Publisher, Classification, Copies, Borrowed, Status) values ('" + this.txtBookName.Text + "','" + this.txtAuthor.Text + "','" + this.txtPublisher.Text +  "', '" + this.cbxClassification.Text + "','" + this.nupCopies.Value + "','" + 0 + "', '" + "Available" +"'); ";
            MySqlCommand mcd = new MySqlCommand(addData, mcon);
            if (string.IsNullOrWhiteSpace(txtPublisher.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(cbxClassification.Text) ||
                string.IsNullOrWhiteSpace(txtBookName.Text) || string.IsNullOrWhiteSpace(nupCopies.Text) || nupCopies.Value == 0)
            {
                MessageBox.Show("Fill all the fields!", "Incomplete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }

            else
            {

                if (mcon.State == ConnectionState.Open)

                    try
                    {

                        
                        mcd.ExecuteNonQuery();
                        MessageBox.Show(txtBookName.Text + " was added to database!", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                     
                        txtPublisher.Clear();
                        txtAuthor.Clear();
                        txtBookName.Clear();
                        nupCopies.Equals(0);

                       
                        this.Close();
                        this.Dispose();
                        mcon.Close();

                    }

                    catch (MySqlException ex)
                    {
                        int erCode = ex.Number;
                        if (erCode == 1062)
                        {
                            MessageBox.Show(txtPublisher.Text + " has a duplicate in the database." , "Duplicate",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                            mcon.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error" + ex, "Duplicate",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        }
                    }
                catch (FormatException)
                    {
                        MessageBox.Show("Invalid value on \"Copies\" ", "Duplicate",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        mcon.Close();
                    }
                
            }          
            mcon.Close();
            this.Close();
            mainWindow.LoadDataTable();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            mcon.Close();
        }

        private void Add_Book_Dialog_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }



    }
}