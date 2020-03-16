using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication_GetTemperature;


namespace WindowsFormsApplication_GetTemperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetTemp_Click(object sender, EventArgs e)
        {
            string city, temp;
            city = comboBox1.SelectedItem.ToString();


            GetTemMethod GTM = new GetTemMethod();
            temp=GTM.GetTemMethodtemp(city);
            label1.Text = temp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
