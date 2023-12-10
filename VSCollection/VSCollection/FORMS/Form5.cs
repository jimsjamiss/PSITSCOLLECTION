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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void loadgrid()
        {
            UserInfo userInfo = new UserInfo();
            gridList.DataSource = userInfo.vw_YearReport();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            loadgrid();
        }
    }
}
