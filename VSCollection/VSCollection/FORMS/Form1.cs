﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSCollection.FORMS;

namespace VSCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pSITSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show(); 
            this.Hide();
            //asd
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void eVENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EventList().Show(); 
            this.Hide();
        }
    }
}
