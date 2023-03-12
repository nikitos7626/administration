using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administration
{


    public partial class authorization : Form
    {
        

        Logic l = new Logic();
        public authorization()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void authorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (l.Authorize(textBox1.Text, textBox2.Text)== role.admin)
            {
                this.Hide();
                admin new_admin_form = new admin();
                new_admin_form.Show();
                Logic.login_user = textBox1.Text;



            }
            else if (l.Authorize(textBox1.Text, textBox2.Text) == role.user)
            {
                this.Hide();
                 user_base new_user_form = new user_base();
                new_user_form.Show();
                Logic.login_user = textBox1.Text;


            }

        }
    }
}
