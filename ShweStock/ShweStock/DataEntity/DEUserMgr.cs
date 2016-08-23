using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShweStock
{
    class DEUserMgr
    {
        #region +++ public access method (Constructor) +++

        public DEUserMgr()
        {
            this.UserId = 0;
            this.UserRoleId = 0;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.CreatedDate = DEGlobal.dateTime_ToDayDate;
            this.CreatedBy = DEGlobal.int32_UserID;
            this.UpdatedDate = DEGlobal.dateTime_ToDayDate;
            this.UpdatedBy = DEGlobal.int32_UserID;
            this.IsActive = true;
            this.Action = 0;
        }

        #endregion

        #region +++ properties declaration +++
        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public int Action { get; set; }




        #endregion
    }
}
