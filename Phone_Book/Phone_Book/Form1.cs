using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Reg rg= new Reg();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            search_data rg = new search_data();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            about rg = new about();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are exiting");
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "NB: Enter you prefered Calculator path here";
            this.process1.Start();      
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          /*  if(e.KeyCode==Keys.R)
            {
                toolStripButton1_Click(sender, e);
            }
            if (e.KeyCode == Keys.S)
            {
                toolStripButton5_Click(sender, e);
            }
            if (e.KeyCode == Keys.C)
            {
                toolStripButton4_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton2_Click(sender, e);
            }
            if(e.KeyCode == Keys.A)
            {
                toolStripButton3_Click(sender, e);
            }
          */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Page Loading...........................................");
        }
    }
}
