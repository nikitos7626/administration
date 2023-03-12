
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administration
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public authorization newForm = new authorization();

        public  void Hide_window()
        {
            this.Hide();

        }

         

        private void button1_Click(object sender, EventArgs e)
        {

            Logic l = new Logic();

            if (textBox4.Text == "473229")
            {
                label1.Text = l.SaveOne((textBox1.Text), textBox2.Text, (textBox3.Text),role.admin ).ToString();
            }
            else
            {
                label1.Text = l.SaveOne((textBox1.Text), textBox2.Text, (textBox3.Text),role.user).ToString(); 
            }
            authorization newForm = new authorization();
            newForm.Show();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            newForm.Show();
        }
    }
}
