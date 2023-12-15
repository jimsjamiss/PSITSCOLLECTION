using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSCollection.Model;
using VSCollection.Utils;
using VSCollection.Model;
using VSCollection.Repository;
using VSCollection.AppData;


namespace VSCollection
{
    public partial class Form7 : Form
    {
        DBCollectionEntities2 db;
        UserInfo user;
        public Form7()
        {
            InitializeComponent();
            user = new UserInfo();
            db = new DBCollectionEntities2();
        }
        private void loadAdmin()
        {
            using (db = new DBCollectionEntities2())
            {
                var Admin = db.Admin.ToList();

                cbAdmin.ValueMember = "id";
                cbAdmin.DisplayMember = "adminName";
                cbAdmin.DataSource = Admin;


            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            loadAdmin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userLogged = user.GetUserByUsername1(cbAdmin.Text);

            if (userLogged != null)
            {
                if (userLogged.password.Equals(txtPassword.Text))
                {
                    UserLogged.GetInstance().admin = userLogged;

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

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void aDMINToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
