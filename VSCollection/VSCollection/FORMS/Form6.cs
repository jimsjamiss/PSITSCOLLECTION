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
using VSCollection.Utils;
using VSCollection.Model;

namespace VSCollection
{
    public partial class Form6 : Form
    {
        DBCollectionEntities1 db;
        UserInfo user;
        public Form6()
        {
            InitializeComponent();
            db = new DBCollectionEntities1();
            user = new UserInfo();
        }
        private void loadOfficer()
        {
            using (db = new DBCollectionEntities1())
            {
                var officer = db.Officer.ToList();

                cbPosition.ValueMember = "id";
                cbPosition.DisplayMember = "Position";
                cbPosition.DataSource = officer;


            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            loadOfficer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userLogged = user.GetUserByUsername(cbPosition.Text);

            if (userLogged != null)
            {
                if (userLogged.password.Equals(txtPassword.Text))
                {
                    UserLogged.GetInstance().officer = userLogged;

                    switch ((Roles)userLogged.roleId)
                    {
                        
                        case Roles.Staff:
                            new Form1().Show();
                            this.Hide();
                            break;
                        case Roles.Admin:
                            new Form3().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void aDMINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }
    }
}
