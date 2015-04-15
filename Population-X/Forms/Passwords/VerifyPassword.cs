using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_X.Forms.Passwords
{
    public partial class VerifyPassword : Form
    {

        public delegate void PasswordStatusHandler(bool Accepted);
        public event PasswordStatusHandler PasswordStatus;

        public VerifyPassword()
        {
            InitializeComponent();
        }

        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPassword.Text == Properties.Settings.Default.PasswordOne)
                {
                    PasswordStatus(true);
                    this.Close();
                }
                else
                {
                    PasswordStatus(false);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string exm = ex.Message; ;
                throw;
            }

        }

        internal void Die()
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string exm = ex.Message;
                throw;
            }

        }
    }
}
