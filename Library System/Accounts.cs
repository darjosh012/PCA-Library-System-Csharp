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
    public partial class Accounts : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();

        public Accounts()
        {
            InitializeComponent();
            LoadDataTable();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Add_User addUser = new Add_User();
            addUser.Show();
        }

        public void LoadDataTable()
        {

            string bookQuery = String.Format("SELECT library_users.user_ID, library_users.Name, library_users.username, library_users.Priviledge, library_users.Contact_Number FROM library_users");
            MySqlCommand mcdTable = new MySqlCommand(bookQuery, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mcdTable);
            DataTable booksTable = new DataTable();
            adapter.Fill(booksTable);
            dataGrid_UsersList.DataSource = booksTable;

            dataGrid_UsersList.Update();
            dataGrid_UsersList.Refresh();
            this.Refresh();

        }

        public void ReloadMainWindow()
        {
            this.Hide();
            this.Show();
        }

        private void picDelete1_Click(object sender, EventArgs e)
        {
            try
            {
                int BookID = Convert.ToInt32(dataGrid_UsersList.SelectedRows[0].Cells["user_ID"].Value.ToString());
                mcon.Open();
                string deleteUser = "Delete from library_users where user_ID =" + BookID;
                MySqlCommand mcd = new MySqlCommand(deleteUser, mcon);
                mcd.Parameters.AddWithValue(Convert.ToString(BookID), mcon);

                String userName = dataGrid_UsersList.SelectedRows[0].Cells["username"].Value.ToString();
                var dialogDelete = MessageBox.Show("Do you want to delete " + userName + "?",
               "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogDelete == System.Windows.Forms.DialogResult.Yes)
                {
                    if (mcon.State == ConnectionState.Open)

                    {

                        int rowsAffected = mcd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            LoadDataTable();
                            ReloadMainWindow();
                            MessageBox.Show(userName + " was removed from database!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show(userName + " is not existed in the database:\n", "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            mcon.Close();

                        }
                    }

                }
                else
                {
                    mcon.Close();
                }
            }

            catch (MySqlException ex)
            {
                String BookName = dataGrid_UsersList.SelectedRows[0].Cells["username"].Value.ToString();
                MessageBox.Show(BookName + " was unable to remove:\n" + ex, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                mcon.Close();
            }
            catch (Exception ex)
            {
                // Do Nothing
            }



            LoadDataTable();
            mcon.Close();

        }
    }
}
