using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = dateTimePicker1.Value;
            DateTime dateTime2 = dateTimePicker2.Value;
            label1.Text = Convert.ToString(DateTimeFunctions.DifferenceBetweenDates(dateTime1,dateTime2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(DateTimeFunctions.IsLeapYear(Convert.ToInt32(textBox1.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(DateTimeFunctions.TimeOfDay(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
        }
    }
}
