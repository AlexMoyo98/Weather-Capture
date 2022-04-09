using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Math;

namespace WeatherCaptureDemo
{
    public partial class favorite : Form
    {

        public favorite()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCity.SelectedIndex > -1)
            {
                int sin;
                sin = cbCity.SelectedIndex;
                int item;
                item = cbCity.SelectedIndex;
                cbFav.Items.Add(cbCity.Text);
            }
        }

        private void favorite_Load(object sender, EventArgs e)
        {

        }
        //fill the list
        private void button1_Click_1(object sender, EventArgs e)
        {
            cbCity.Items.Clear();
            cbCity.Items.Add("Durban");
            cbCity.Items.Add("Johannesburg");
            cbCity.Items.Add("Pretoria");
            cbCity.Items.Add("Cape Town");
            cbCity.Items.Add("Polokwane");
            cbCity.Items.Add("Tzaneen");
            cbCity.Items.Add("Rustenburg");
            cbCity.Items.Add("Port Elizabeth");
            cbCity.Items.Add("Mbombela");
            cbCity.Text = "Select from";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbCity.Items.Clear();
        }
        //sorting the list
        private void btnSort_Click(object sender, EventArgs e)
        {
            cbCity.Sorted = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // listBox1.SelectedIndexChanged;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
           

            List<string> matchedList = new List<string>();
            string citation;
            citation = cbFav.Text;
            string filepath = @"C:\\Users\\Alex Moyo\\source\\repos\\WeatherCaptureDemo\\WeatherCaptureDemo\\Weather file\\weather.txt";
            string[] linesArr = File.ReadAllLines(filepath);

            //find the matches

            foreach (string s in linesArr)
            {
                if (s.Contains(citation))
                {
                    matchedList.Add(s);

                }
            }
            //output
            foreach (string s in matchedList)
            {
                richTextBox1.Text = s;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            cbFav.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
