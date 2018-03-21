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

    public partial class Delete_Book_Dialog : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        Main_Window mainWindow = new Main_Window();

        public Delete_Book_Dialog()
        {
            InitializeComponent();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                string addData = "Delete from books where Book_ID =" + txtBookID.Text;
                MySqlCommand mcd = new MySqlCommand(addData, mcon);
                mcd.Parameters.AddWithValue(txtBookID.Text, mcon);

                if (string.IsNullOrWhiteSpace(txtBookID.Text))
                {
                    MessageBox.Show("Fill all the fields!", "Incomplete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }

                else
                {

                    if (mcon.State == ConnectionState.Open)

                    {

                        int rowsAffected = mcd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(txtBookID.Text + " was removed from database!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtBookID.Clear();

                            this.Close();
                            mcon.Close();
                        
                        }
                        else
                        {
                            MessageBox.Show(txtBookID.Text + " is not existed in the database:\n"  , "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            mcon.Close();

                        }
                    }

                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(txtBookID.Text + " was unable to remove:\n" + ex, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                mcon.Close();
            }
            mainWindow.LoadDataTable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

