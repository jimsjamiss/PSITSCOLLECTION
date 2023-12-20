using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSCollection.AppData;
using VSCollection.FORMS;
using VSCollection.Repository;


namespace VSCollection
{
    public partial class Form3 : Form
    {
        UserInfo userInfo1;
        public Form3()

        {
           userInfo1 = new UserInfo();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var officers = userInfo1.vw_Admin().Where(o => o.OFFICERS.ToLower().Contains(searchText.ToLower())).ToList();
                gridAdmin.DataSource = officers;
            }
            else
            {
                loadgrid(); 
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void eVENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EventList().Show();
            this.Hide();
        }
    }
}
