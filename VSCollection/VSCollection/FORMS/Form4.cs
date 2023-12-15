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


namespace VSCollection
{
   
    public partial class Form4 : Form
    {
        DBCollectionEntities1 db;
        public Form4()
        {
            InitializeComponent();
            db = new DBCollectionEntities1();
        }

        private void loadOfficer()
        {
            using (db = new DBCollectionEntities1())
            {
                var officer = db.Officer.ToList();

                cbOfficers.ValueMember = "id";
                cbOfficers.DisplayMember = "Position";
                cbOfficers.DataSource = officer;

               
            }
        }

        private void loadEvent()
        {
            using (db = new DBCollectionEntities1())
            {
                var events = db.Event.ToList();

                cbEvent.ValueMember = "id";
                cbEvent.DisplayMember = "EventName";
                cbEvent.DataSource = events;


            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadOfficer();
            loadEvent();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (db = new DBCollectionEntities1())
            {
                if (String.IsNullOrEmpty(txtIDNum.Text))
                {
                    errorProvider1.SetError(txtIDNum, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtFName.Text))
                {
                    errorProvider1.SetError(txtFName, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtLName.Text))
                {
                    errorProvider1.SetError(txtLName, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtCourse.Text))
                {
                    errorProvider1.SetError(txtCourse, "Empty Field");
                    return;
                }


                Student nstudent = new Student();
                nstudent.IDNumber = Convert.ToInt32(txtIDNum.Text);
                nstudent.FName = txtFName.Text;
                nstudent.LName = txtLName.Text;
                nstudent.Course = txtCourse.Text;
                

                Officer officer = new Officer();
                officer.id = cbOfficers.SelectedIndex + 1;

                Event Event = new Event();
                Event.id = cbEvent.SelectedIndex + 1;

                Year year = new Year();
                year.yearLevel = Convert.ToInt32(txtYear.Text);

                db.Student.Add(nstudent);
                db.Officer.Add(officer);
                db.Event.Add(Event);
                db.Year.Add(year);
                db.SaveChanges();

                cbOfficers.SelectedIndex = 0;
                cbEvent.SelectedIndex = 0;
                txtFName.Clear();
                txtLName.Clear();
                txtCourse.Clear();
                txtIDNum.Clear();
                MessageBox.Show("Registered!");

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new Form4().Close();
            this.Hide();
            new Form1().Show();
            
        }
    }
}
