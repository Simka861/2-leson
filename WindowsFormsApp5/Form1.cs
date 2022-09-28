using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string  button1 = " * ";
            label1.Text += button1;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string button2 = " / ";
            label1.Text += button2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string button3 = " + ";
            label1.Text += button3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string button4 = " - ";
            label1.Text += button4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string button5 = " = ";
            label1.Text += button5;
            bool a = label1.Contains(button1);
            if (a) { String word = label1.IndexOf(' '); }
            label1.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string button6 = "1";
            label1.Text += button6;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            string button7 = "2";
            label1.Text += button7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string button8 = "3";
            label1.Text += button8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string button9 = "4";
            label1.Text += button9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string button10 = "5";
            label1.Text += button10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string button11 = "6";
            label1.Text += button11;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string button12 = "7";
            label1.Text += button12;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string button13 = "8";
            label1.Text += button13;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string button14 = "9";
            label1.Text += button14;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string button15 = "0";
            label1.Text += button15;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            label1.Show();  
        }
    }
}
