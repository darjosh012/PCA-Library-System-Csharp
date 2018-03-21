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

namespace Library_System
{

    public partial class Form2 : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        MySqlCommand mcd1 = new MySqlCommand();
        sbyte trials = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var dialogExit = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialogExit == System.Windows.Forms.DialogResult.Yes)
            {
                mcon.Close();
                Application.Exit();
            }
            }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                mcd.CommandText = "Select * from library_users where username='" + txtUsername.Text + "' and password='" + mtxtPassword.Text + "'";
                mcd.Connection = mcon;
                MySqlDataReader login = mcd.ExecuteReader();



                sbyte result = 0;
                while (login.Read())
                {
                    result++;

                }
                if (result == 1)
                {
                    /*Main_Window form2 = new Main_Window(); //(txtUsername.Text)
                    form2.Show();
                    */
                    login.Close();
                    OriginalMainMenu origMain = new OriginalMainMenu();
                    origMain.Show();
                    this.Hide();

                    mcd1.Connection = mcon;
                    mcd1.CommandText = "SELECT Name from library_users where username = '" + txtUsername.Text +"';";
                    string NameUser = mcd1.ExecuteScalar().ToString();
                    string firstWord = NameUser.Split(' ').FirstOrDefault();
                    origMain.lblUsername.Text = firstWord;
                    mcon.Close();


                }

                else if (trials == 5)
                {
                    MessageBox.Show("You've been guessing the password multiple times. The program will now exit.", "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Wrong username or password.", "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    trials++;

                    mtxtPassword.Clear();
                }
                mcon.Close();

            }

            // This code will check if SQL injection is detected.
            catch (MySqlException ex)
            {
                MessageBox.Show(ex + "SQL Injection Detected. Program will now exit.", "Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
    }
    }

