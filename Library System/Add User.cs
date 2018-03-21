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
    public partial class Add_User : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        Accounts accounts = new Accounts();

        public Add_User()
        {
            InitializeComponent();
            this.FormClosed += delegate { this.Dispose(); accounts.Show(); };
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            mcon.Open();
            string FullName= txtFirstName.Text + " " + txtLastName.Text;
            string addUser = "INSERT INTO library_users (Name, username, password, priviledge, Contact_Number) values ('" + FullName + "','"  + this.txtUsername.Text + "', '" + this.txtPassword.Text + "','" + this.cbxPriviledge.Text + "' , '" + this.txtContactNumber.Text + "'); ";
            MySqlCommand mcd = new MySqlCommand(addUser, mcon);
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cbxPriviledge.Text) || string.IsNullOrWhiteSpace(txtContactNumber.Text))
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
                        txtLastName.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtContactNumber.Clear();

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
            accounts.LoadDataTable();
            accounts.ReloadMainWindow();
            mcon.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }


