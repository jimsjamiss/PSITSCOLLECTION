using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSCollection.Repository;

namespace VSCollection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        public void loadgrid()
        {
            UserInfo userInfo = new UserInfo();
            gridAdmin.DataSource = userInfo.vw_Admin();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadgrid();
        }
    }
}
