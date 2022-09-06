///////////////////////////////////////////////////////
//t info 200 A
//L4calc - a simple calculator app in c#
// 1/19/22 - ericrod - initialization of project
// 1/27/22 - ericrod - made the rest of the number buttons function and display
// 1/28/22 - ericrod - added functionality to operator buttons and equals sign
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
        private double firstNumber;
        private double secondNumber;
        private char operator1;
        public Form1()
        {
            InitializeComponent();
        }
        //number buttons that adds to the window display
        private void number0Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "0";
        }
        private void number1Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "1";
        }
        private void number2Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "2";
        }
        private void number3Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "3";
        }
        private void number4Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "4";
        }
        private void number5Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "5";
        }
        private void number6Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "6";
        }
        private void number7Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "7";
        }
        private void number8Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "8";
        }
        private void number9Btn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + "9";
        }
        private void dotBtn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text + ".";
        }
        private void signBtn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = (double.Parse(displayWindow.Text) * -1).ToString();
        }
        //"resets" the window display
        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            displayWindow.Text =  "";
        }
        //resets the number and char and also resets the window display
        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            operator1 = '\0';
            displayWindow.Text = "";
        }
        //take the length and remove the last number
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            displayWindow.Text = displayWindow.Text.Remove(displayWindow.Text.Length - 1);
        }

        //operators
        //use a char which will be used later as a switch statement
        private void addBtn_Click(object sender, EventArgs e)
        {
            firstNumber = (double.Parse(displayWindow.Text));
            operator1 = '+';
            displayWindow.Text = "";
        }
        private void minusBtn_Click(object sender, EventArgs e)
        {
            firstNumber = (double.Parse(displayWindow.Text));
            operator1 = '-';
            displayWindow.Text = "";
        }
        private void timesBtn_Click(object sender, EventArgs e)
        {
            firstNumber = (double.Parse(displayWindow.Text));
            operator1 = '*';
            displayWindow.Text = "";
        }
        private void divideBtn_Click(object sender, EventArgs e)
        {
            firstNumber = (double.Parse(displayWindow.Text));
            operator1 = '/';
            displayWindow.Text = "";
        }
        private void equalBtn_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(displayWindow.Text);
            
            //finds which operator was clicked and takes the 2nd number and does the math
            switch(operator1)
            {
                case '+':  
                    displayWindow.Text = (firstNumber + secondNumber).ToString();
                    break;
                case '-':
                    displayWindow.Text = (firstNumber - secondNumber).ToString();
                    break;
                case '*':
                    displayWindow.Text = (firstNumber * secondNumber).ToString();
                    break;
                case '/':
                    displayWindow.Text = (firstNumber / secondNumber).ToString();
                    break;
            }
            
        }

    }
}
