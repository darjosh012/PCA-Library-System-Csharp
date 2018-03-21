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

namespace Library_System.Properties
{
    public partial class Book_Issued : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();

        public Book_Issued()
        {
            InitializeComponent();
            LoadDataTable();
        }
        public void LoadDataTable()
        {

            string bookQuery = String.Format("SELECT * FROM {0}", "books_issued");
            MySqlCommand mcdTable = new MySqlCommand(bookQuery, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mcdTable);
            DataTable booksTable = new DataTable();
            adapter.Fill(booksTable);
            dataGridIssued.DataSource = booksTable;

            dataGridIssued.Update();
            dataGridIssued.Refresh();
            this.Refresh();

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void picBorrow_Click(object sender, EventArgs e)
        {
            Borrow_Dialog borrowDialog = new Borrow_Dialog();
            borrowDialog.Show();
            
            
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                int IssuedID = Convert.ToInt32(dataGridIssued.SelectedRows[0].Cells["Issued_ID"].Value.ToString());
                int BookID = Convert.ToInt32(dataGridIssued.SelectedRows[0].Cells["Book_fk"].Value.ToString());
                int Copies = Convert.ToInt32(dataGridIssued.SelectedRows[0].Cells["Copies"].Value.ToString());
                System.DateTime DateExpectedReturn = Convert.ToDateTime(dataGridIssued.SelectedRows[0].Cells["Date_ExpectedReturn"].Value.ToString());
                int exceedingDays = DateTime.Now.Day - DateExpectedReturn.Day;

                string selectBorrowed = "SELECT Borrowed from books where Book_ID =" + BookID;
                MySqlCommand selectmcd = new MySqlCommand(selectBorrowed, mcon);
                int Borrowed = Convert.ToInt32(selectmcd.ExecuteScalar().ToString());


                string returnBook = "DELETE from books_issued where Issued_ID =" + IssuedID;
                MySqlCommand mcd = new MySqlCommand(returnBook, mcon);
                mcd.Parameters.AddWithValue(Convert.ToString(IssuedID), mcon);

                String BookName = dataGridIssued.SelectedRows[0].Cells["Book_Name"].Value.ToString();
                String Borrower = dataGridIssued.SelectedRows[0].Cells["Borrower"].Value.ToString();
                var dialogDelete = MessageBox.Show("Do you want to return " + BookName + "?",
               "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogDelete == System.Windows.Forms.DialogResult.Yes)
                {
                    if (mcon.State == ConnectionState.Open)

                    {
                        if (System.DateTime.Now <= DateExpectedReturn.Date)
                        {
                            int rowsAffected = mcd.ExecuteNonQuery();                      
                            if (rowsAffected > 0)
                            {
                                LoadDataTable();
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
                                MessageBox.Show(BookName + " is not existed in the database:\n", "Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                mcon.Close();

                            }


                        }

                        else
                        {
                            double Price = 5.00 * exceedingDays;
                            string penaltyBooks = "INSERT into Penalty (Book_Name, Book_ID, Borrower, Exceeding_Days, Price) values ('" + BookName + "','" + BookID + "','" + Borrower + "','" + exceedingDays + "','" + Price + "'); ";
                            string deleteIssuedgoPenalty = "DELETE from books_issued where Issued_ID =" + IssuedID;
                            MySqlCommand mcddeleteIssuedgoPenalty = new MySqlCommand(deleteIssuedgoPenalty, mcon);
                            MySqlCommand mcdpenalty = new MySqlCommand(penaltyBooks, mcon);

                            MessageBox.Show("Please proceed to the Penalty Window. " + Borrower + " exceeds "
                                + exceedingDays + ".", "Penalty",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            mcdpenalty.ExecuteNonQuery();
                            mcddeleteIssuedgoPenalty.ExecuteNonQuery();

                            mcon.Close();



                        }
                        
                  
                    

                }
                    
                }
                mcon.Close();
            }
          
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Book_Issued_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                LoadDataTable();
            }
        }
        private void picRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
