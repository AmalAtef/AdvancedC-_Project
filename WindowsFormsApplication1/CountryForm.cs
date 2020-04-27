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
using WindowsFormsApplication1.SL;

namespace WindowsFormsApplication1
{
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void CountryForm_Load(object sender, EventArgs e)
        {
           
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = CountrySL.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country r = CountrySL.GetById(Convert.ToInt32(getId.Text));
            if (r == null)
                countryName.Text = null;
            else
            countryName.Text = r.Name;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CountrySL.Add(newCountry.Text) > 0)
                WrongMsg.Text = "Country Added";
            else
                WrongMsg.Text = "Con't Add";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             if (CountrySL.Delete(Convert.ToInt32(delCountryId.Text)) > 0)
                WrongMsg2.Text = "Country Deleted";
            else
                WrongMsg2.Text = "Con't Delete";
        }
    }
}
