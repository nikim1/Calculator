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
        double result = 0;
        string mathOperation = "";
        bool isOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || isOperation)
                textBox_result.Clear();

            isOperation = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;
            }
            else
            {
                textBox_result.Text = textBox_result.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                button16.PerformClick();
                mathOperation = button.Text;
                labelOperation.Text = result + " " + mathOperation;
                isOperation = true;
            }
            else
            {
                mathOperation = button.Text;
                result = double.Parse(textBox_result.Text);
                labelOperation.Text = result + " " + mathOperation;
                isOperation = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (mathOperation)
            {
                case "+":
                    textBox_result.Text = (result + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (result - double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (result * double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (result / double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox_result.Text);
            labelOperation.Text = "";
        }
    }
}
