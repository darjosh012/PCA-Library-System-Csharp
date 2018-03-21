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
    public partial class Faculty_Dialog : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();

        public Faculty_Dialog()
        {
            InitializeComponent();
            this.FormClosed += delegate { this.Dispose(); };
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Faculty addFaculty = new Add_Faculty();
            addFaculty.Show();
        }
        public void LoadDataTable()
        {

            string bookQuery = String.Format("SELECT * FROM {0}", "faculty");
            MySqlCommand mcdTable = new MySqlCommand(bookQuery, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mcdTable);
            DataTable booksTable = new DataTable();
            adapter.Fill(booksTable);
            dataGrid_FacultyList.DataSource = booksTable;

            dataGrid_FacultyList.Update();
            dataGrid_FacultyList.Refresh();
            this.Refresh();

        }

        private void Faculty_Dialog_Load(object sender, EventArgs e)
        {

        }

        public void ReloadMainWindow()
        {
            this.Hide();
            this.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
