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
    public partial class Add_Faculty : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        Faculty_Dialog facultyDialog = new Faculty_Dialog();

        public Add_Faculty()
        {
            InitializeComponent();
            this.FormClosed += delegate { this.Dispose(); facultyDialog.ShowDialog(); };
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mcon.Open();
            string addStudent = "INSERT INTO faculty (Faculty_FirstName, Faculty_MiddleName, Faculty_LastName, Faculty_Department) values ('" + this.txtFirstName.Text + "','" + this.txtMiddleName.Text + "','" + this.txtLastName.Text + "','" + this.txtDepartment.Text + "'); ";
            MySqlCommand mcd = new MySqlCommand(addStudent, mcon);
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtDepartment.Text))
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
                        MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " was added to database!", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                        txtFirstName.Clear();
                        txtMiddleName.Clear();
                        txtLastName.Clear();
                        txtDepartment.Clear();

                        this.Close();
                        mcon.Close();

                    }

                    catch (MySqlException ex)
                    {
                        int erCode = ex.Number;
                        if (erCode == 1062)
                        {
                            MessageBox.Show(txtFirstName.Text + " " + txtLastName + " has a duplicate in the database.", "Duplicate",
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

            }
            facultyDialog.LoadDataTable();
            facultyDialog.ReloadMainWindow();
            mcon.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

