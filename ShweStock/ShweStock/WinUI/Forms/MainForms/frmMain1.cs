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
    public partial class frmMain1 : Form
    {
        public frmMain1()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            ucSetup ucSetup = new ucSetup();
            ucSetup.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucSetup);
        }
    }
}
