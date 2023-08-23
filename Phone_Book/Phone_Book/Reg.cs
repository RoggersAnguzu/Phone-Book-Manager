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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Page Loading");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = true;
            this.groupBox1.Enabled = true;
            //-------Clears DATA in the TextBoxes------//
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            this.textBox9.ResetText();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text=="")
            {
                MessageBox.Show("Mandatory to Enter the ID");
                return;
            }
            this.toolStripButton2.Enabled = false;
            this.toolStripButton1.Enabled = true;
            this.groupBox1.Enabled = false;
            //---------This Saves the Data----------//
            string file;
            file = "D:\\A-PRACTICES\\";
            string determiner;
            //---------First Name--------------//
            determiner =file +this.textBox1.Text + "_Fn1.txt"; 
            System.IO.File.WriteAllText(determiner,this.textBox2.Text,Encoding.UTF8);
            //----------Last Name-------------//
            determiner = file + this.textBox1.Text + "_Fn2.txt"; 
            System.IO.File.WriteAllText(determiner, this.textBox3.Text, Encoding.UTF8);
            //----------Tel-------------//
            determiner = file + this.textBox1.Text + "_Fn3.txt"; 
            System.IO.File.WriteAllText(determiner, this.textBox4.Text, Encoding.UTF8);
            //----------Cell -------------//
            determiner = file + this.textBox1.Text + "_Fn4.txt"; 
            System.IO.File.WriteAllText(determiner, this.textBox5.Text, Encoding.UTF8);
            //----------Email-------------//
            determiner = file + this.textBox1.Text + "_Fn5.txt"; 
            System.IO.File.WriteAllText(determiner, this.textBox6.Text, Encoding.UTF8);
            //----------Address-------------//
            determiner = file + this.textBox1.Text + "_Fn6txt"; 
            System.IO.File.WriteAllText(determiner, this.textBox7.Text, Encoding.UTF8);
            //----------Comment-------------//
            determiner = file + this.textBox1.Text + "_Fn7.txt"; 
            System.IO.File.WriteAllText(determiner, this.textBox9.Text, Encoding.UTF8);
            MessageBox.Show("Credentials Saved Successfully");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
