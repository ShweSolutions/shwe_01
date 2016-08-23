using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShweStock
{
    public partial class frmLogin : Form
    {
        DataTable dt_User { get; set; }
        int i = 1;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string userName = txtUserName.Text;
            string password = Encrypt(txtPassword.Text);
            DEUserMgr u = new DEUserMgr();
            u.UserName = userName;
            u.Password = password;
            UserMgrBLL obj_UserMgrBLL = new UserMgrBLL();
            dt_User = obj_UserMgrBLL.getUserByNameAndPassword(u);
            if (dt_User.Rows.Count == 0)
            {
                if (i != 3)
                {
                    MessageBox.Show("Invalid UserName or Password!", "Unauthorized Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    i++;
                }
                else
                {

                    MessageBox.Show("You have already tried 3 times. Your password may have been changed. Please contact your system administrator.", "Unauthorized Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                DEGlobal.int32_UserID = Convert.ToInt32(dt_User.Rows[0]["UserId"].ToString());
                DEGlobal.int32_UserRoleID = Convert.ToInt32(dt_User.Rows[0]["UserRoleId"].ToString());
                this.Hide();
                frmMain main = new frmMain();
                main.Show();

            }
        }
        //private string Encrypt(string clearText)
        //{
        //    string EncryptionKey = "MAKV2SPBNI99212";
        //    byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(clearBytes, 0, clearBytes.Length);
        //                cs.Close();
        //            }
        //            clearText = Convert.ToBase64String(ms.ToArray());
        //        }
        //    }
        //    return clearText;
        //}

        public string Encrypt(string plainText)
        {
            try
            {
                byte[] encData_byte = new byte[plainText.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(plainText);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

    }
}
