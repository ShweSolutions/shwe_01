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
    public partial class ucSetup : UserControl
    {
        public ucSetup()
        {
            InitializeComponent();
        }

        private void btnUserMgr_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            ucUserMgrSetup control = new ucUserMgrSetup();
            control.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(control);
        }

    }
}
