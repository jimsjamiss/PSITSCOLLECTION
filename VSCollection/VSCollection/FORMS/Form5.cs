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
        UserInfo userInfo;
        public Form5()
        {
            userInfo = new UserInfo();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var students = userInfo.vw_YearReport().Where(s => s.Student_Name.ToLower().Contains(searchText.ToLower()) || s.Student_Name.ToLower().Contains(searchText.ToLower())).ToList();
                gridList.DataSource = students;
            }
            else
            {
                loadgrid(); 
            }
        }
    }
}
