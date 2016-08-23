using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShweStock
{
    class UserMgrDAL
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEUserMgr u)
        {
            SqlCmd.Parameters.AddWithValue("@UserId", u.UserId);
            SqlCmd.Parameters.AddWithValue("@UserName", u.UserName);
            SqlCmd.Parameters.AddWithValue("@Password", u.Password);
            SqlCmd.Parameters.AddWithValue("@UserRoleId", u.UserRoleId);
            SqlCmd.Parameters.AddWithValue("@CreatedDate", u.CreatedDate);
            SqlCmd.Parameters.AddWithValue("@CreatedBy", u.CreatedBy);
            SqlCmd.Parameters.AddWithValue("@UpdatedDate", u.UpdatedDate);
            SqlCmd.Parameters.AddWithValue("@UpdatedBy", u.UpdatedBy);
            SqlCmd.Parameters.AddWithValue("@IsActive", u.IsActive);
            SqlCmd.Parameters.AddWithValue("@Action", u.Action);

            return SqlCmd;
        }

        #endregion

        public DataTable getAllUserRoles()
        {
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = "sp_getAllUserRoles";
            cmd.CommandType = CommandType.StoredProcedure;
            return GenericDataAccess.ExecuteSelectCommand(cmd);
        }

        public int CUUsers(DEUserMgr u)
        {
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            DeclareSqlCmdParameter(cmd, u);
            cmd.CommandText = "sp_CUUsers";
            cmd.CommandType = CommandType.StoredProcedure;
            return GenericDataAccess.ExecuteNonQuery(cmd);

        }

        public DataTable getAllUsers(DEUserMgr u)
        {
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            //DeclareSqlCmdParameter(cmd, u);
            cmd.CommandText = "sp_getAllUsers";
            cmd.CommandType = CommandType.StoredProcedure;
            return GenericDataAccess.ExecuteSelectCommand(cmd);
        }

        public DataTable getUserByNameAndPassword(DEUserMgr u)
        {
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            DeclareSqlCmdParameter(cmd, u);
            cmd.CommandText = "sp_getUserAndPassword";
            cmd.CommandType = CommandType.StoredProcedure;
            return GenericDataAccess.ExecuteSelectCommand(cmd);
        }

    }
}
