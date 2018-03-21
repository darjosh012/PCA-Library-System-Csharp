using System;
using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 loginScreen = new Form2();

            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
            }

            catch (MySqlException)
            {
                tmr_toLogin.Enabled = false;
                MessageBox.Show("Database cannot be found. Program will now exit", "Missing",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void tmr_toLogin_Tick(object sender, EventArgs e)
        {
            Form2 loginScreen = new Form2();
            loginScreen.Show();
            this.Hide();
            tmr_toLogin.Enabled = false;

        }
    }
}
