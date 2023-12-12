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

namespace VSCollection
{
    public partial class Form2 : Form
    {
        UserInfo userInfo;
        int studentID;

        public Form2()
        {
            userInfo = new UserInfo();
            InitializeComponent();
        }

        public void loadgrid()
        {
            UserInfo userInfo = new UserInfo();
            gridPsits.DataSource = userInfo.vw_PSITs();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String strOutputMsg = "";
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                errorProviderCustom.SetError(txtSearch, "Empty Field");
                return;
            }
            ErrorCode retValue = userInfo.DeleteRoomUsingStoredProf(Convert.ToInt32(txtSearch.Text), ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                loadgrid();

                txtSearch.Text = "";
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProviderCustom = new ErrorProvider();
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("Please provide a valid ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int sid = Convert.ToInt32(txtSearch.Text);
                String strOutputMsg = "";

                // Correctly call GetStudentID method
                Student studentInfo = userInfo.GetStudentID(sid); // Ensure GetStudentID returns a Student object

                if (studentInfo == null)
                {
                    MessageBox.Show("Student ID not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Correctly call UpdateRoomUsingStoredProf method
                ErrorCode sValue = userInfo.UpdateRoomUsingStoredProf(sid, Convert.ToInt32(txtIDNum.Text), txtFName.Text, txtLName.Text, txtCourse.Text, ref strOutputMsg);

                if (sValue == ErrorCode.Success)
                {
                    errorProviderCustom.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadgrid(); // Refresh grid after update

                    txtSearch.Clear();
                    txtIDNum.Clear();
                    txtFName.Clear();
                    txtLName.Clear();
                    txtCourse.Clear();
                }
                else
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


