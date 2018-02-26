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
        Double resultValue = 0;
        String operationPerformed = "";
        Boolean isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
            resultValue = 0;
        }

        private void button_click(object sender, EventArgs e)

        {
            if ((textbox_result.Text == "0") || (isOperationPerformed))
                textbox_result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            

            if (button.Text == "."){
            
                if (!textbox_result.Text.Contains ("."))
                    textbox_result.Text = textbox_result.Text + button.Text;

            }else
                textbox_result.Text = textbox_result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button16.PerformClick();

                operationPerformed = button.Text;
               // resultValue = Double.Parse(textbox_result.Text);
                labelCurrentOperation.Text = resultValue + "" + operationPerformed;
                isOperationPerformed = true;
            }
            else { 


            operationPerformed = button.Text;
            resultValue = Double.Parse(textbox_result.Text);
            labelCurrentOperation.Text = resultValue + "" + operationPerformed;
            isOperationPerformed = true;

        }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
        }

        private void button_click15(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textbox_result.Text = (resultValue + Double.Parse(textbox_result.Text)).ToString();
                    break;

                case "-":
                    textbox_result.Text = (resultValue - Double.Parse(textbox_result.Text)).ToString();
                    break;

                case "*":
                    textbox_result.Text = (resultValue * Double.Parse(textbox_result.Text)).ToString();
                    break;

                case "/":
                    textbox_result.Text = (resultValue / Double.Parse(textbox_result.Text)).ToString();
                    break;

                default:
                    break;

            }
            resultValue = Double.Parse(textbox_result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
