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
using Library_System.Properties;

namespace Library_System
{
    public partial class Main_Window : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        

       public Main_Window()
        {
            InitializeComponent();
            PlaceHolder();
            LoadDataTable();
            this.FormClosing += delegate { this.Dispose(); };


        }

        public void LoadDataTable()
        {

            string bookQuery = String.Format("SELECT * FROM {0}", "books");
            MySqlCommand mcdTable = new MySqlCommand(bookQuery, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mcdTable);
            DataTable booksTable = new DataTable();
            adapter.Fill(booksTable);
            dataGrid_BookList.DataSource = booksTable;

            dataGrid_BookList.Update();
            dataGrid_BookList.Refresh();
            this.Refresh();
            mcon.Close();

        }

        private void PlaceHolder()
        {
            txtSearchBox.Enter += new EventHandler(this.txtSearchBox_Enter);
            txtSearchBox.Leave += new EventHandler(this.txtSearchBox_Leave);

        }



        private void picAdd_Click(object sender, EventArgs e)
        {
            Add_Book_Dialog addBook = new Add_Book_Dialog();
            this.Hide();
            addBook.ShowDialog();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int BookID = Convert.ToInt32(dataGrid_BookList.SelectedRows[0].Cells["Book_ID"].Value.ToString());
                int Borrowed = Convert.ToInt32(dataGrid_BookList.SelectedRows[0].Cells["Borrowed"].Value.ToString());
                mcon.Open();
                string addData = "Delete from books where Book_ID =" + BookID;
                MySqlCommand mcd = new MySqlCommand(addData, mcon);
                mcd.Parameters.AddWithValue(Convert.ToString(BookID), mcon);

                String BookName = dataGrid_BookList.SelectedRows[0].Cells["Book_Name"].Value.ToString();
                var dialogDelete = MessageBox.Show("Do you want to delete " + BookName + "?" , 
               "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Borrowed == 0)
                {
                    if (dialogDelete == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (mcon.State == ConnectionState.Open)

                        {

                            int rowsAffected = mcd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                LoadDataTable();
                                MessageBox.Show(BookName + " was removed from database!", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show(BookName + " is not existed in the database:\n", "Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                mcon.Close();

                            }
                        }

                        LoadDataTable();
                        mcon.Close();

                    }
                }
                else
                {
                    MessageBox.Show("You can't delete a book when it is borrowed", "Unable",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                    mcon.Close();
                }
            }

            catch (MySqlException ex)
            {
                String BookName = dataGrid_BookList.SelectedRows[0].Cells["Book_Name"].Value.ToString();
                MessageBox.Show(BookName + " was unable to remove:\n" + ex, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                mcon.Close();
            }
            catch (Exception ex)
            {
               // Do Nothing
            }            
    }
        

        private void picRefresh_Click(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            cbxClassification.Text = "All";
            LoadDataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            mcon.Open();
           
            if (string.IsNullOrWhiteSpace(txtSearchBox.Text) | txtSearchBox.Text == "Search Book")
            { 
                //no action
            }
            else
            {
                try {

                    if (cbxClassification.Text == "All")
                    {
                        string searchData = "Select * FROM books WHERE Book_Name like '" + txtSearchBox.Text + "%';";
                        MySqlCommand mcd = new MySqlCommand(searchData, mcon);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(mcd);
                        adapter.SelectCommand = mcd;
                        DataTable booksTable = new DataTable();
                        booksTable.Clear();
                        adapter.Fill(booksTable);
                        dataGrid_BookList.DataSource = booksTable;
                    }
                    else
                    {
                        string searchData = "Select * from books where Classification = '" + cbxClassification.Text + "' && Book_Name like '%" + txtSearchBox.Text + "';";
                        MySqlCommand mcd = new MySqlCommand(searchData, mcon);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(mcd);
                        adapter.SelectCommand = mcd;
                        DataTable booksTable = new DataTable();
                        booksTable.Clear();
                        adapter.Fill(booksTable);
                        dataGrid_BookList.DataSource = booksTable;
                    }
                    
                    if (dataGrid_BookList.Rows.Count == 0)
                    {
                     MessageBox.Show(txtSearchBox.Text + " is not existing in the database ", "Not Found",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
                    }
                }

                catch (MySqlException ex)
                {
                     MessageBox.Show(txtSearchBox.Text + " is not existing in the database ", "Not Found",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
                }
            }
            mcon.Close();
        }

        public void txtSearchBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Search Book")
            {
                tb.ForeColor = Color.Black;
                tb.Text = "";
            }
        }

        public void txtSearchBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.ForeColor = Color.LightGray;
                tb.Text = "Search Book";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void picUserTile_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            try
            {
                



                this.Hide();
                Update_Dialog updateDialog = new Update_Dialog();
                updateDialog.txtBookName.Text = dataGrid_BookList.SelectedRows[0].Cells["Book_Name"].Value.ToString();
                updateDialog.txtAuthor.Text = dataGrid_BookList.SelectedRows[0].Cells["Author"].Value.ToString();
                updateDialog.txtPublisher.Text = dataGrid_BookList.SelectedRows[0].Cells["Publisher"].Value.ToString();
                updateDialog.cbxClassification.Text = dataGrid_BookList.SelectedRows[0].Cells["Classification"].Value.ToString();
                updateDialog.nupCopies.Text = dataGrid_BookList.SelectedRows[0].Cells["Copies"].Value.ToString();
                updateDialog.BookID = Convert.ToInt32(dataGrid_BookList.SelectedRows[0].Cells["Book_ID"].Value.ToString());
                updateDialog.ShowDialog();
                

            }
            catch (Exception ex)
            {
                // Do Nothing
            }
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pcalibrary_databaseDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.pcalibrary_databaseDataSet.books);

        }
        
        private void picBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                string availability = dataGrid_BookList.SelectedRows[0].Cells["Status"].Value.ToString();
                string bookName = dataGrid_BookList.SelectedRows[0].Cells["Book_Name"].Value.ToString();

                if (availability == "Available")
                {
                    this.Hide();
                    Borrow_Dialog borrowDialog = new Borrow_Dialog();
                    borrowDialog.BookID = Convert.ToInt32(dataGrid_BookList.SelectedRows[0].Cells["Book_ID"].Value.ToString());
                    borrowDialog.txtBookName.Text = dataGrid_BookList.SelectedRows[0].Cells["Book_Name"].Value.ToString();
                    borrowDialog.Copies = Convert.ToInt32(dataGrid_BookList.SelectedRows[0].Cells["Copies"].Value.ToString());
                    borrowDialog.borrowed = Convert.ToInt32(dataGrid_BookList.SelectedRows[0].Cells["Borrowed"].Value.ToString());
                    borrowDialog.ShowDialog();
                    this.Hide();
                    
                   
                    
                }
                else
                {
                    MessageBox.Show(bookName +  " is not available at this moment.", "Not Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                // Do Nothing
            }

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBox.Text) || txtSearchBox.Text == "Search Book")
            {
                LoadDataTable();
            }

            else
            {
                try {
                    if (cbxClassification.Text == "All")
                    {
                        string searchData = "Select * FROM books WHERE Book_Name like '" + txtSearchBox.Text + "%';";
                        MySqlCommand mcd = new MySqlCommand(searchData, mcon);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(mcd);
                        adapter.SelectCommand = mcd;
                        DataTable booksTable = new DataTable();
                        booksTable.Clear();
                        adapter.Fill(booksTable);
                        dataGrid_BookList.DataSource = booksTable;
                    }
                    else
                    {
                        string searchData = "Select * from books where Classification = '" + cbxClassification.Text + "' && Book_Name like '%" + txtSearchBox.Text + "';";
                        MySqlCommand mcd = new MySqlCommand(searchData, mcon);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(mcd);
                        adapter.SelectCommand = mcd;
                        DataTable booksTable = new DataTable();
                        booksTable.Clear();
                        adapter.Fill(booksTable);
                        dataGrid_BookList.DataSource = booksTable;
                    }
                }
                catch (Exception)
                {
                    //Do nothing
                }
            }

            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
