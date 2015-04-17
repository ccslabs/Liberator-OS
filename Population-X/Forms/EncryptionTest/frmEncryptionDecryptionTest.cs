using Population_X.Classes.DEFS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_X.Forms.EncryptionTest
{
    public partial class frmEncryptionDecryptionTest : Form
    {
        public delegate void EncryptionDecryptionTestLogHandler(string Message);
        public event EncryptionDecryptionTestLogHandler EncryptionDecryptionTestLog;

        FileSystemEncryption fse = new FileSystemEncryption();

        public frmEncryptionDecryptionTest()
        {
            InitializeComponent();
        }

        private void btnEncryptTest_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbStringToEncrypt.Text))
            {
                tbEncryptedText.Text = GetString(fse.Encrypt(GetBytes(tbStringToEncrypt.Text)));
                tbEncryptedBytes.Text = BitConverter.ToString(GetBytes(tbEncryptedText.Text));
                tbDecryptedText.Text = GetString(fse.Decrypt(GetBytes(tbEncryptedText.Text)));
            }
            else if(string.IsNullOrEmpty(tbStringToEncrypt.Text) && !string.IsNullOrEmpty(tbEncryptedText.Text))
            {
                // Only decrypt
                tbEncryptedBytes.Text = BitConverter.ToString(GetBytes(tbEncryptedText.Text));
                tbDecryptedText.Text = GetString(fse.Decrypt(GetBytes(tbEncryptedText.Text)));
            }
            else
            {
                if (EncryptionDecryptionTestLog != null) EncryptionDecryptionTestLog("No Text entered to test!");
            }
        }

        internal byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
