using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShweStock
{
    class UserMgrBLL
    {
        public DataTable getAllUserRoles()
        {
            UserMgrDAL obj_UserMgrDAL = new UserMgrDAL();
            DataTable dtUserRoles = obj_UserMgrDAL.getAllUserRoles();
            obj_UserMgrDAL = null;
            return dtUserRoles;

        }

        public int CUUsers(DEUserMgr u)
        {
            UserMgrDAL obj_UserMgrDAL = new UserMgrDAL();

            int int_Result = obj_UserMgrDAL.CUUsers(u);

            obj_UserMgrDAL = null;

            return int_Result;
        }

        public DataTable getAllUsers(DEUserMgr u)
        {
            UserMgrDAL obj_UserMgrDAL = new UserMgrDAL();

            DataTable dt_Users = obj_UserMgrDAL.getAllUsers(u);

            obj_UserMgrDAL = null;

            return dt_Users;
        }

        public DataTable getUserByNameAndPassword(DEUserMgr u)
        {
            UserMgrDAL obj_UserMgrDAL = new UserMgrDAL();
            DataTable dt_User = obj_UserMgrDAL.getUserByNameAndPassword(u);
            obj_UserMgrDAL = null;
            return dt_User;

        }
    }
}
