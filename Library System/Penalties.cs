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
    public partial class Penalties : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");

        public Penalties()
        {
            InitializeComponent();
            LoadDataTable();
            this.FormClosed += delegate { this.Dispose(); };
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            try {
            mcon.Open();
            int PenaltyID = Convert.ToInt32(dataGridPenalty.SelectedRows[0].Cells["Penalty_ID"].Value.ToString());
            int BookID = Convert.ToInt32(dataGridPenalty.SelectedRows[0].Cells["Book_ID"].Value.ToString());
            String BookName = dataGridPenalty.SelectedRows[0].Cells["Book_Name"].Value.ToString();
            String Borrower = dataGridPenalty.SelectedRows[0].Cells["Borrower"].Value.ToString();
            string returnBook = "DELETE from Penalty where Penalty_ID =" + PenaltyID;

            MySqlCommand mcd = new MySqlCommand(returnBook, mcon);
            var dialogDelete = MessageBox.Show("Do you want to return " + BookName + "?",
               "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                string selectCopies = "SELECT Copies from books where Book_ID =" + BookID;
                MySqlCommand selectCopiesmcd = new MySqlCommand(selectCopies, mcon);
                int Copies = Convert.ToInt32(selectCopiesmcd.ExecuteScalar().ToString());


                if (dialogDelete == System.Windows.Forms.DialogResult.Yes)
                {
                    if (mcon.State == ConnectionState.Open)

                    {
                        int rowsAffected = mcd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string selectBorrowed = "SELECT Borrowed from books where Book_ID =" + BookID;
                            MySqlCommand selectmcd = new MySqlCommand(selectBorrowed, mcon);
                            int Borrowed = Convert.ToInt32(selectmcd.ExecuteScalar().ToString());
                            int totalBorrowed = Borrowed - 1;

                            MessageBox.Show(BookName + " was succesfully returned by " + Borrower, "Success!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (totalBorrowed == Copies)
                            {
                                string RefreshBook = "Update books set borrowed = '" + totalBorrowed + "', Status = '" + "Not Available" + "' where Book_ID = '" + BookID + "';";
                                MySqlCommand mcdRefresh = new MySqlCommand(RefreshBook, mcon);
                                mcdRefresh.ExecuteNonQuery();


                            }
                            else
                            {
                                string RefreshBook = "Update books set borrowed = '" + totalBorrowed + "', Status = '" + "Available" + "' where Book_ID = '" + BookID + "';";
                                MySqlCommand mcdRefresh = new MySqlCommand(RefreshBook, mcon);
                                mcdRefresh.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show(BookName + " was not succesfully returned", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    
                }
                LoadDataTable();
                mcon.Close();
            }
            catch (Exception)
            {
                // Do nothing
            }
        }
        public void LoadDataTable()
        {
            string bookQuery = String.Format("SELECT * FROM {0}", "Penalty");
            MySqlCommand mcdTable = new MySqlCommand(bookQuery, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mcdTable);
            DataTable booksTable = new DataTable();
            adapter.Fill(booksTable);
            dataGridPenalty.DataSource = booksTable;

            dataGridPenalty.Update();
            dataGridPenalty.Refresh();
            this.Refresh();

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}