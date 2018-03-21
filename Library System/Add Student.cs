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
    public partial class Add_Student : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        Student_Dialog studentDialog = new Student_Dialog();

        public Add_Student()
        {
            InitializeComponent();
            this.FormClosed += delegate { this.Dispose(); studentDialog.Show(); };
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
        mcon.Open();
            string student_name = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;
            string addStudent = "INSERT INTO students (Student_Name, Section, Year, Address, Contact_Number) values ('" + student_name + "','" + this.txtSection.Text + "','" + this.txtYear.Text + "','" + this.txtAddress.Text + "','" + this.txtContactNumber.Text + "'); ";
        MySqlCommand mcd = new MySqlCommand(addStudent, mcon);
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtMiddleName.Text) || string.IsNullOrWhiteSpace(txtSection.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtContactNumber.Text))
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
                        MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text +" was added to database!", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                     
                        txtFirstName.Clear();
                        txtMiddleName.Clear();
                        txtLastName.Clear();
                        txtSection.Clear();
                        txtYear.Clear();

                        this.Close();
                        mcon.Close();

    }

                    catch (MySqlException ex)
                    {
                        int erCode = ex.Number;
                        if (erCode == 1062)
                        {
                            MessageBox.Show(txtFirstName.Text + " " + txtLastName + " has a duplicate in the database." , "Duplicate",
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
            studentDialog.LoadDataTable();
            studentDialog.ReloadMainWindow();
            mcon.Close();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
