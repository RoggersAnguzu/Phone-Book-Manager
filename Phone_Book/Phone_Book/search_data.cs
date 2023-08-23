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
    public partial class search_data : Form
    {
        public search_data()
        {
            InitializeComponent();
        }

        private void search_data_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Page Loading********");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox8.Text == "")
            {
                MessageBox.Show("Mandatory to Enter the ID");
                return;
            }
            string file;
            file = "D:\\A-PRACTICES\\";
            string determiner;
            string read;
            //---------First Name--------------//
            determiner = file + this.textBox8.Text + "_Fn1.txt";
            if (System.IO.File.Exists(determiner)==true)
            {
                read = System.IO.File.ReadAllText(determiner, Encoding.UTF8);
                this.textBox2.Text = read;
            }
            determiner = file + this.textBox8.Text + "_Fn2.txt";
            if (System.IO.File.Exists(determiner) == true)
            {
                read = System.IO.File.ReadAllText(determiner, Encoding.UTF8);
                this.textBox3.Text = read;
            }
            determiner = file + this.textBox8.Text + "_Fn3.txt";
            if (System.IO.File.Exists(determiner) == true)
            {
                read = System.IO.File.ReadAllText(determiner, Encoding.UTF8);
                this.textBox4.Text = read;
            }
            determiner = file + this.textBox8.Text + "_Fn4.txt";
            if (System.IO.File.Exists(determiner) == true)
            {
                read = System.IO.File.ReadAllText(determiner, Encoding.UTF8);
                this.textBox5.Text = read;
            }
            determiner = file + this.textBox8.Text + "_Fn5.txt";
            if (System.IO.File.Exists(determiner) == true)
            {
                read = System.IO.File.ReadAllText(determiner, Encoding.UTF8);
                this.textBox6.Text = read;
            }
            determiner = file + this.textBox8.Text + "_Fn6.txt";
            if (System.IO.File.Exists(determiner) == true)
            {
                read = System.IO.File.ReadAllText(determiner, Encoding.UTF8);
                this.textBox7.Text = read;
            }
            determiner = file + this.textBox8.Text + "_Fn7.txt";
            if (System.IO.File.Exists(determiner) == true)
            {
                read = System.IO.File.ReadAllText(determiner, Encoding.UTF8);
                this.textBox9.Text = read;
            }
            
        }
    }
}
