using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShweStock
{
    public partial class ucUserMgrSetup : UserControl
    {
        public ucUserMgrSetup()
        {
            InitializeComponent();
            bindUserRoles();
            bindDataGridView();
            txtUserName.Focus();
        }

        public void bindUserRoles()
        {
            UserMgrBLL obj_UserMgrBLL = new UserMgrBLL();
            DataTable dtUserRoles = obj_UserMgrBLL.getAllUserRoles();
            cbbUserRole.Items.Clear();
            cbbUserRole.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbbUserRole.SourceDataString = new string[] { "UserRoleName", "UserRoleId" };
            cbbUserRole.ColumnNum = 2;
            cbbUserRole.ColumnWidth = "150;0";
            cbbUserRole.SourceDataTable = dtUserRoles;
            cbbUserRole.Text = string.Empty;
        }

        private Boolean ValidateUserInput()
        {
            bool bool_Test = true;

            if (txtUserName.Text.Trim().Length == 0)
            {
                bool_Test = false;
                errorProvider1.SetError(txtUserName, "Plase Enter UserName");
                string str_error = errorProvider1.GetError(txtUserName);
                MessageBox.Show(str_error, "Save Fail");
            }
            else if (txtPassword.Text.Trim().Length == 0)
            {
                bool_Test = false;
                errorProvider1.SetError(txtPassword, "Plase Enter Password!");
                string str_error = errorProvider1.GetError(txtPassword);
                MessageBox.Show(str_error, "Save Fail");
            }

            else if (txtPassword.Text.Trim().Length < 4)
            {
                bool_Test = false;
                errorProvider1.SetError(txtPassword, "Your Password must have 4 characters at least!");
                string str_error = errorProvider1.GetError(txtPassword);
                MessageBox.Show(str_error, "Save Fail");
            }

            else if (cbbUserRole.Text.Trim().Length == 0 || cbbUserRole.SelectedValue == null)
            {
                bool_Test = false;
                errorProvider1.SetError(cbbUserRole, "Plase Select User Role");
                string str_error = errorProvider1.GetError(cbbUserRole);
                MessageBox.Show(str_error, "Save Fail");
            }

            errorProvider1.Clear();
            return bool_Test;
        }

        private void AssignData(DEUserMgr u)
        {
            u.UserId = Convert.ToInt32(txtUserName.Tag);
            u.UserName = txtUserName.Text.Trim();
            u.Password = Encrypt(txtPassword.Text.Trim());
            u.UserRoleId = Convert.ToInt32(cbbUserRole.SelectedItem.Col2);
            u.UpdatedBy = DEGlobal.int32_UserID;
            if (u.UserId == 0)
                u.Action = 1;
            else
                u.Action = 2;
        }

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

        public string Decrypt(string sData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        private void save()
        {
            DEUserMgr u = new DEUserMgr();
            AssignData(u);

            UserMgrBLL obj_UserMgrBLL = new UserMgrBLL();

            try
            {
                int int_Result = obj_UserMgrBLL.CUUsers(u);
                MessageBox.Show(UIConstantMessage.Const_strSaveSuccessfully);
                bindDataGridView();
                ClearData();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                u = null;
                obj_UserMgrBLL = null;
            }

        }

        private void ClearData()
        {
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtUserName.Tag = 0;
            cbbUserRole.SelectedIndex = -1;


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                this.save();
            }
        }

        private void btn_Rest_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void bindDataGridView()
        {
            UserMgrBLL obj_UserMgrBLL = new UserMgrBLL();
            DEUserMgr u = new DEUserMgr();
            DataTable dt_Users = obj_UserMgrBLL.getAllUsers(u);

            dgvUser.DataSource = dt_Users;
            dgvUser.Columns[1].Visible = false;
            dgvUser.Columns[2].Width = 200;
            dgvUser.Columns[3].Width = 300;
            dgvUser.Columns[4].Visible = false;
            dgvUser.Columns[5].Visible = false;

            ClearData();

        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DEUserMgr u = new DEUserMgr();

            try
            {

                u.UserId = Convert.ToInt32(dgvUser.CurrentRow.Cells["UserId"].Value);
                u.UserName = Convert.ToString(dgvUser.CurrentRow.Cells["UserName"].Value);
                u.Password = Convert.ToString(dgvUser.CurrentRow.Cells["Password"].Value);
                u.UserRoleId = Convert.ToInt32(dgvUser.CurrentRow.Cells["UserRoleId"].Value);


                displayData(u);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            u = null;
        }

        private void displayData(DEUserMgr u)
        {
            txtUserName.Tag = u.UserId;
            txtUserName.Text = u.UserName;
            txtPassword.Text = Decrypt(u.Password);
            cbbUserRole.SelectedValue = u.UserRoleId.ToString();

        }

    }
}
