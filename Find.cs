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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> matchedList = new List<string>();
            string citation;
            citation = CbCity.Text;
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
        foreach(string s in matchedList)
            {
                richTextBox1.Text = s;
            }

        }

        private void Find_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            favorite x = new favorite();
            x.ShowDialog();
        }
    }
}
