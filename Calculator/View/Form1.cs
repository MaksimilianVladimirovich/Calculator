using Calculator.Controller;
using Calculator.Model;
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
        private ElementsOfOperation ElementsOfOperation = new ElementsOfOperation();

        /// <summary>
        /// This flag is needed for correct input (user can't enter two operations in one time ) 
        /// </summary>
        private bool MakingOperation = false;


        public Form1()
        {
            InitializeComponent();
            EnterTextBox.Text = "";
        }
        #region Buttons
        private void button0_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('0');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonWithNumberClick('9');
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (ElementsOfOperation.Operation == '\0' && !EnterTextBox.Text.Contains(",") && EnterTextBox.Text.Count() != 0)
            {
				ButtonWithNumberClick(',');
			}

            if (ElementsOfOperation.Operation != '\0' && !EnterTextBox.Text.Remove(0, ElementsOfOperation.FirstNumber.ToString().Count() + 1).Contains(",") && EnterTextBox.Text.Remove(0, ElementsOfOperation.FirstNumber.ToString().Count() + 1).Count() > 0)
            {
				ButtonWithNumberClick(',');
			}
        }
        #endregion

        #region Operations
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("=") && EnterTextBox.Text.Count() > 0)
            {
                ButtonWithOperationClick('=');
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("+") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('+');
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("-") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('-');
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("*") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('*');
            }
        }

        private void buttonDevision_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("/") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('/');
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("a") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('a');
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("b") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('b');
            }
        }

        private void button1Devision_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("c") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('c');
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (!EnterTextBox.Text.Contains("%") && EnterTextBox.Text.Count() > 0 && MakingOperation == false)
            {
                ButtonWithOperationClick('%');
            }
        }

        /// <summary>
        /// Delete last inserted element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (ElementsOfOperation.FirstNumber.ToString().Count() + 1 < EnterTextBox.Text.Count() && ElementsOfOperation.Operation != '\0')
            {
                EnterTextBox.Text = EnterTextBox.Text.Substring(0, ElementsOfOperation.FirstNumber.ToString().Count() + 1);
            }
            else
            {
                MakingOperation = false;
                EnterTextBox.Clear();
				ElementsOfOperation.FirstNumber = 0;
				ElementsOfOperation.Operation = ' ';
				ElementsOfOperation.SecondNumber = 0;
				ElementsOfOperation.SecondNumber = 0;
			}
        }

        /// <summary>
        /// Delete all, except last element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            if (ElementsOfOperation.Operation != '\0' && ElementsOfOperation.FirstNumber.ToString().Count() + 1 < EnterTextBox.Text.Count())
            {
                MakingOperation = false;
                EnterTextBox.Text = EnterTextBox.Text.Substring(ElementsOfOperation.FirstNumber.ToString().Count() + 1);
                
                ElementsOfOperation.FirstNumber = 0;
                ElementsOfOperation.Operation = '\0';
            }
        }

        /// <summary>
        /// Delete last number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (EnterTextBox.Text.Count() > 0)
            {
                //Deleting last inserted symbol
                if (ElementsOfOperation.Operation != '\0' && EnterTextBox.Text.Last() == ElementsOfOperation.Operation)
                {
                    ElementsOfOperation.Operation = '\0';
                    MakingOperation = false;
				}
                if(EnterTextBox.Text == ElementsOfOperation.FirstNumber.ToString())
                {
                    ElementsOfOperation.FirstNumber = Convert.ToDouble(EnterTextBox.Text.Remove(EnterTextBox.Text.Count() - 1) == "" ? 0 : Convert.ToDouble(EnterTextBox.Text.Remove(EnterTextBox.Text.Count() - 1)));
				}
                EnterTextBox.Text = EnterTextBox.Text.Remove
                    (EnterTextBox.Text.LastIndexOf(EnterTextBox.Text.Last()));
            }
        }
        #endregion
        private void ButtonWithNumberClick(char number)
        {
            if (EnterTextBox.Text.Count() < 15)
            {
                EnterTextBox.Text += number;
            }
            else 
            {
				MessageBox.Show("Ошибка! Количество введенных символов не должно превышать пятнадцати.\nErorr! Try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }

        private void ButtonWithOperationClick(char operation)
        {
            EnterTextBox.Text += operation;

            if (operation != '=')
            {
                MakingOperation = true;

                //Adding operation to the structure
                ElementsOfOperation.Operation = operation;

                //Adding first number with deleting operation sign
                ElementsOfOperation.FirstNumber = Convert.ToDouble(EnterTextBox.Text.Remove
                    (EnterTextBox.Text.LastIndexOf(EnterTextBox.Text.Last())));
            }

            //Operations that requiring one number
            if (ElementsOfOperation.Operation == 'a')
            {
                EnterTextBox.Text = DoOperation.Root(ElementsOfOperation).ToString();
                MakingOperation = false;
                ElementsOfOperation.FirstNumber = 0;
                ElementsOfOperation.SecondNumber = 0;
            }

            if (ElementsOfOperation.Operation == 'b')
            {
                EnterTextBox.Text = DoOperation.Square(ElementsOfOperation).ToString();
                MakingOperation = false;
                ElementsOfOperation.FirstNumber = 0;
                ElementsOfOperation.SecondNumber = 0;
            }

            if (ElementsOfOperation.Operation == 'c')
            {
                EnterTextBox.Text = DoOperation.Division1ToX(ElementsOfOperation).ToString();
                MakingOperation = false;
                ElementsOfOperation.FirstNumber = 0;
                ElementsOfOperation.SecondNumber = 0;
            }


            //Operations that requiring two numbers
            if (operation == '=')
            {
                if (double.TryParse(EnterTextBox.Text.Remove
                    (EnterTextBox.Text.LastIndexOf(EnterTextBox.Text.Last())).Substring
                    (ElementsOfOperation.FirstNumber.ToString().Count() + 1), out double result))
                {
                    //Adding second number and deleting from string first number and operations signs
                    ElementsOfOperation.SecondNumber = result;
                }               
                else
                {
                    MessageBox.Show("Ошибка! Попробуйте еще раз.\nErorr! Try again.","",MessageBoxButtons.OK , MessageBoxIcon.Warning);

                    EnterTextBox.Text = EnterTextBox.Text.Remove(0);
                    ElementsOfOperation.FirstNumber = 0;
					ElementsOfOperation.Operation = '\0';
					ElementsOfOperation.SecondNumber = 0;
                    MakingOperation = false;
					return;
                }

                EnterTextBox.Clear();
                
                if (ElementsOfOperation.Operation == '+')
                {
                    EnterTextBox.Text = DoOperation.Sum(ElementsOfOperation).ToString();
                }

                if (ElementsOfOperation.Operation == '-')
                {
                    EnterTextBox.Text = DoOperation.Minus(ElementsOfOperation).ToString();
                }

                if (ElementsOfOperation.Operation == '*')
                {
                    EnterTextBox.Text = DoOperation.Multiplication(ElementsOfOperation).ToString();
                }

                if (ElementsOfOperation.Operation == '/')
                {
                    EnterTextBox.Text = DoOperation.Division(ElementsOfOperation).ToString();
                }

                if (ElementsOfOperation.Operation == '%')
                {
                    EnterTextBox.Text = DoOperation.Percent(ElementsOfOperation).ToString();
                }

                MakingOperation = false;
                ElementsOfOperation.FirstNumber = 0;
                ElementsOfOperation.SecondNumber = 0;
				ElementsOfOperation.Operation = '\0';
			}
        }
    }
}
