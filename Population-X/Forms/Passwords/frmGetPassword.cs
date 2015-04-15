using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_X.Forms
{
    public partial class frmGetPassword : Form
    {
        public frmGetPassword()
        {
            InitializeComponent();
        }

        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text.Length > 5)
            {
                Properties.Settings.Default.PasswordOne = tbPassword.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password is too short");
            }
        }
    }
}
