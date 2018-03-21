using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_System
{

    public partial class Update_Dialog : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        Main_Window mainWindow = new Main_Window();
        public int BookID;
        

        public Update_Dialog()
        {
            InitializeComponent();
            this.FormClosed += delegate { this.Dispose(); mainWindow.ShowDialog(); };
        }

        private void Update_Dialog_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            mcon.Open();
            string updateData = "Update books set Author = '" + txtAuthor.Text + "', Publisher = '" + txtPublisher.Text + "', Classification = '" + cbxClassification.Text + "', Copies= '" + nupCopies.Value + "' where Book_ID = '" + BookID + "';";
            MySqlCommand mcd = new MySqlCommand(updateData, mcon);
            if (string.IsNullOrWhiteSpace(txtPublisher.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(cbxClassification.Text) ||
                string.IsNullOrWhiteSpace(txtBookName.Text) || string.IsNullOrWhiteSpace(nupCopies.Text) || nupCopies.Equals(0))
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
                        MessageBox.Show(txtBookName.Text + " was updated to database!", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                        txtPublisher.Clear();
                        txtAuthor.Clear();
                        txtBookName.Clear();
                        nupCopies.Equals(0);

                        mcon.Close();
                        this.Close();
                        this.Dispose();

                        mainWindow.LoadDataTable();
                    }

                    catch (MySqlException ex)
                    {
                        {
                            MessageBox.Show("Cannot update " + txtBookName.Text + ex, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                            mcon.Close();
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
        }
    }

}
