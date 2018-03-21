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

    public partial class Borrow_Dialog : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        Main_Window mainWindow = new Main_Window();

        public int BookID;
        public int Copies;
        public int borrowed;

        public Borrow_Dialog()
        {
            InitializeComponent();
            this.FormClosed += delegate { mainWindow.ShowDialog(); };
          
        }

        private void Borrow_Dialog_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            mcon.Open();
            int totalBorrowed = borrowed + 1;
            System.DateTime ExpectedReturnDate = DateTime.Now.AddDays(3);

            string borrowBook = "INSERT INTO books_issued(Book_fk, Book_Name, Date_Issued, Date_ExpectedReturn, Borrower, Copies, Borrowed) values ('" + BookID + "', '" + txtBookName.Text + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "', '" + ExpectedReturnDate.ToString("yyyy/MM/dd") + "' , '" + cbxStudentName.Text + "' , '" + Copies + "' , '"+ 1 + "');";
            MySqlCommand mcd = new MySqlCommand(borrowBook, mcon);
            if (string.IsNullOrWhiteSpace(txtBookName.Text) || string.IsNullOrWhiteSpace(txtBookName.Text))
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
                        MessageBox.Show(cbxStudentName.Text + " borrowed " + txtBookName.Text + " book" , "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                        txtBookName.Clear();
                        cbxStudentName.Text = "";

                        if (Copies == totalBorrowed)
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
                        this.Dispose();
                        this.Close();
                        mcon.Close();
                    }

                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR" + ex, "Duplicate",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        mcon.Close();
                    }

            }
            mainWindow.LoadDataTable();
            mcon.Close();
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
