using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Type two valid numbers");
            }
            

            if (textBox1.Text == null || textBox2.Text == null)
            {
                MessageBox.Show("Enter numbers in both fields");
            }
            else if (radioButton1.Checked)
            {
                var ans = a + b;
                MessageBox.Show($"{ans}");
            }
            else if (radioButton2.Checked)
            {
                var ans = a - b;
                MessageBox.Show($"{ans}");
            }
            else if (radioButton3.Checked)
            {
                var ans = a * b;
                MessageBox.Show($"{ans}");
            }
            else if (radioButton4.Checked)
            {
                var ans = a / b;
                MessageBox.Show($"{ans}");
            }
            else
            {
                MessageBox.Show("Select operator");
            }
        }
    }
}
