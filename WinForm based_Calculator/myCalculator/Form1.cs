using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class MyCalculator : Form
    {
        double x = 0; //result when press the equal button.
        double y = 0; //the first input number.
        string z;   //operator
        bool i = false; //c will be set to true when press an operator, 
                        //then press another number, the numbers on the label will be clear.

        Button[] btn = new Button[18];
        
        public MyCalculator()
        {
            InitializeComponent();
            btn[0] = button0;
            btn[1] = button1;
            btn[2] = button2;
            btn[3] = button3;
            btn[4] = button4;
            btn[5] = button5;
            btn[6] = button6;
            btn[7] = button7;
            btn[8] = button8;
            btn[9] = button9;
            btn[10] = buttonClear;
            btn[11] = buttonPlusMinus;
            btn[12] = buttonPlus;
            btn[13] = buttonMinus;
            btn[14] = buttonMultiply;
            btn[15] = buttonDivide;
            btn[16] = buttonEqual;
            btn[17] = buttonDecimal;
        }

        private void ButtonOn (int index)
        {
            btn[index].Enabled = true;
            btn[index].Visible = true;
        }
        private void ButtonOff (int index)
        {
            btn[index].Enabled = false;
            btn[index].Visible = false;
        }

        private void buttonONOFF_Click(object sender, EventArgs e)
        {
            if (buttonONOFF.BackColor == Color.DarkRed)
            {
                buttonONOFF.BackColor = Color.DarkGreen;
                ButtonOn(0);
                ButtonOn(1);
                ButtonOn(2);
                ButtonOn(3);
                ButtonOn(4);
                ButtonOn(5);
                ButtonOn(6);
                ButtonOn(7);
                ButtonOn(8);
                ButtonOn(9);
                ButtonOn(10);
                ButtonOn(11);
                ButtonOn(12);
                ButtonOn(13);
                ButtonOn(14);
                ButtonOn(15);
                ButtonOn(16);
                ButtonOn(17);
            }
            else if (buttonONOFF.BackColor == Color.DarkGreen)
            {
                buttonONOFF.BackColor = Color.DarkRed;
                ButtonOff(0);
                ButtonOff(1);
                ButtonOff(2);
                ButtonOff(3);
                ButtonOff(4);
                ButtonOff(5);
                ButtonOff(6);
                ButtonOff(7);
                ButtonOff(8);
                ButtonOff(9);
                ButtonOff(10);
                ButtonOff(11);
                ButtonOff(12);
                ButtonOff(13);
                ButtonOff(14);
                ButtonOff(15);
                ButtonOff(16);
                ButtonOff(17);
            }
                
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            InputOutputLabel.Text = "";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (InputOutputLabel.Text == "")
            {
                InputOutputLabel.Text = "-" + InputOutputLabel.Text;
            }
            else if (InputOutputLabel.Text.IndexOf("-")>=0) //a "-" has existed.
            {
                InputOutputLabel.Text = InputOutputLabel.Text.Remove(0, 1);
            }
            else
            {
                InputOutputLabel.Text = "-" + InputOutputLabel.Text;
            }
        }

        private void NumberInput(string num)
        {
            if (i == true)
            {
                InputOutputLabel.Text = "";
                i = false;
            }
            InputOutputLabel.Text += num;
            if (InputOutputLabel.Text.Length >= 2)
            {
                if (InputOutputLabel.Text.Substring(0, 1) == "0"
                    && InputOutputLabel.Text.Substring(1, 1) != ".")
                {
                    InputOutputLabel.Text = InputOutputLabel.Text.Substring(1);
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberInput("0");
            if (z == "÷")
            {
                InputOutputLabel.Text = "Error: division by Zero!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberInput("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberInput("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberInput("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberInput("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberInput("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberInput("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberInput("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberInput("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberInput("9");
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (InputOutputLabel.Text == "")
            {
                InputOutputLabel.Text = "0.";
            }
            else if (InputOutputLabel.Text.IndexOf(".") >= 0) //a "." has existed.
            {
                InputOutputLabel.Text += "";
            }
            else
            {
                InputOutputLabel.Text += "."; 
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            i = true;
            y = double.Parse(InputOutputLabel.Text);
            z = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            i = true;
            y = double.Parse(InputOutputLabel.Text);
            z = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            i = true;
            y = double.Parse(InputOutputLabel.Text);
            z = "x";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            i = true;
            y = double.Parse(InputOutputLabel.Text);
            z = "÷";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (z)
            {
                case "+":
                    x = y + double.Parse(InputOutputLabel.Text);
                    break;
                case "-":
                    x = y - double.Parse(InputOutputLabel.Text);
                    break;
                case "x":
                    x = y * double.Parse(InputOutputLabel.Text);
                    break;
                case "÷":
                    x = y / double.Parse(InputOutputLabel.Text);
                    break;
            }
            InputOutputLabel.Text = x + "";
            i = true;  //for continue calculating. 
        }
    }
}
