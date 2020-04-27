using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static User currentUser;

        private CountryForm nextScreen = new CountryForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int returnId = SL.UserSL.GetByEmailAndPassword(emailLogin.Text, passwordLogin.Text);

            if (returnId > 0)
            {
                currentUser = new User(returnId, emailLogin.Text, passwordLogin.Text);
                nextScreen.Show();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result= SL.UserSL.Add(email.Text, password.Text);
            if (result > 0)
            {
                nextScreen.Show();
            }

        }
    }
}
