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
    public partial class OriginalMainMenu : Form
    {
        
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='pcalibrary_database';username=root;password=rootadmin");
        MySqlCommand mcd = new MySqlCommand();
        Form2 login = new Form2();

        public OriginalMainMenu()
        {
            InitializeComponent();
            lblUsername.Text = login.txtUsername.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void OriginalMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogExit = MessageBox.Show("Do you want to exit the program?", "Exit", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (dialogExit == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel= true;
            }
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Window BookList = new Main_Window();
            BookList.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var logOut = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (logOut == System.Windows.Forms.DialogResult.Yes)
            {
                mcon.Close();
                Form2 logIn = new Form2();
                this.Hide();
                logIn.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PCA School Library\nVersion: 0.1 Alpha\nDeveloper: Daryll Magsombol and Co.", "About Developer");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
        }

        private void deweyDecimalSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dewee_Decimal_System deweyPic = new Dewee_Decimal_System();
            deweyPic.ShowDialog();
        }

        private void bookIsuueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Issued bookIssued = new Book_Issued();
            bookIssued.ShowDialog();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Dialog studentDialog = new Student_Dialog();
            studentDialog.ShowDialog();
        }

        private void facultyStaffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty_Dialog facultyDialog = new Faculty_Dialog();
            facultyDialog.ShowDialog();
        }

        private void penaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Penalties penalties = new Penalties();
            penalties.ShowDialog();
        }

        private void manageAccountsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Audit_Trail auditTrail = new Audit_Trail();
            auditTrail.ShowDialog();
        }
    }
}