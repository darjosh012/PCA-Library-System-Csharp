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
    public partial class Dewee_Decimal_System : Form
    {
        public Dewee_Decimal_System()
        {
            InitializeComponent();
            this.FormClosed += delegate { this.Dispose(); };
        }

        private void Dewee_Decimal_System_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
