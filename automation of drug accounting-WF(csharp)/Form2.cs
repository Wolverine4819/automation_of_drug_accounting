using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automation_of_drug_accounting_WF_csharp_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form1 s = new Form1();
                s.Show();
                this.Hide();
            }
    else if (textBox1.Text == "user" && textBox2.Text == "user")
            {
                Form3 s = new Form3();
                s.Show();
                this.Hide();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Не верный логин или пароль!");
            }


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
