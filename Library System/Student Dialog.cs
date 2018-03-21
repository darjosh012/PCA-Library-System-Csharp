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
    public partial class Student_Dialog : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();

        public Student_Dialog()
        {
            InitializeComponent();
            LoadDataTable();
            this.FormClosed += delegate { this.Dispose();};
        }

        public void LoadDataTable()
        {

            string bookQuery = String.Format("SELECT * FROM {0}", "students");
            MySqlCommand mcdTable = new MySqlCommand(bookQuery, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mcdTable);
            DataTable booksTable = new DataTable();
            adapter.Fill(booksTable);
            dataGrid_StudentList.DataSource = booksTable;

            dataGrid_StudentList.Update();
            dataGrid_StudentList.Refresh();
            this.Refresh();

        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student addStudent = new Add_Student();
            addStudent.ShowDialog();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            LoadDataTable();
        }
        public void ReloadMainWindow()
        {
            this.Hide();
            this.Show();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int StudentID = Convert.ToInt32(dataGrid_StudentList.SelectedRows[0].Cells["Student_ID"].Value.ToString());
                mcon.Open();
                string addData = "Delete from students where Student_ID =" + StudentID;
                MySqlCommand mcd = new MySqlCommand(addData, mcon);
                mcd.Parameters.AddWithValue(Convert.ToString(StudentID), mcon);

                String FirstName = dataGrid_StudentList.SelectedRows[0].Cells["Student_FirstName"].Value.ToString();
                String LastName = dataGrid_StudentList.SelectedRows[0].Cells["Student_LastName"].Value.ToString();
                String FullStudent = FirstName + " " + LastName;
                var dialogDelete = MessageBox.Show("Do you want to delete " + FullStudent + "?",
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
                            MessageBox.Show(FullStudent + " was removed from database!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show(FullStudent + " is not existed in the database:\n", "Not Found",
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
                String StudentName = dataGrid_StudentList.SelectedRows[0].Cells["Student_FirstName"].Value.ToString();
                MessageBox.Show(StudentName + " was unable to remove:\n" + ex, "Error",
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

        private void picEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
