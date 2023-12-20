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
using VSCollection.Repository;

namespace VSCollection.FORMS
{
    public partial class EventList : Form
    {
       DBCollectionEntities3 db;
        UserInfo userRepo;
        public EventList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userRepo = new UserInfo();
            loadIntramsList4();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnIntrams_Click(object sender, EventArgs e)
        {
            userRepo = new UserInfo();
            loadIntramsList();

        }
        private void btnAcquintance_Click(object sender, EventArgs e)
        {
            userRepo = new UserInfo();
            loadIntramsList1();
        }
        public void loadIntramsList()
        {
           
            dtgEventList.DataSource = userRepo.IntramsList();
        }
        public void loadIntramsList1()
        {

            dtgEventList.DataSource = userRepo.ACQUAINTANCE();
        }
        public void loadIntramsList2()
        {

            dtgEventList.DataSource = userRepo.DAY();
        }
        public void loadIntramsList3()
        {

            dtgEventList.DataSource = userRepo.Congress();
        }
        public void loadIntramsList4()
        {

            dtgEventList.DataSource = userRepo.seminar();
        }

        private void btnGODAY_Click(object sender, EventArgs e)
        {
            userRepo = new UserInfo();
            loadIntramsList2();
        }

        private void btnCongress_Click(object sender, EventArgs e)
        {
            userRepo = new UserInfo();
            loadIntramsList3();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
