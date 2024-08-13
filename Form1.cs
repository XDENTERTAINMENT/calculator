using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        
       Double resultValue = 0;
        String operationperformed = "";
        bool  isoperationperformed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0") || (isoperationperformed))
                textBox1.Clear();
            isoperationperformed = false;

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text; 
            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0");
                textBox1.Clear();
        }

        private void operation_click(object sender, EventArgs e)
        {



            Button operation = (Button)sender;


            operationperformed = operation.Text;
            resultValue = Double.Parse(textBox1.Text);
            lbinput.Text = resultValue + "" + operationperformed ;
            isoperationperformed = true;
            textBox1.Text = textBox1.Text + operation.Text;





        }

        private void btnEqualto_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse (textBox1.Text)).ToString(); 
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "%":
                    textBox1.Text = (resultValue % Double.Parse(textBox1.Text)).ToString();

                    break;
                default:
                    break;
            }
        }

        private void lbinput_Click(object sender, EventArgs e)
        {
            
        }
    }
}
