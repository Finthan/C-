using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        private bool NewNumber = true;
        private double NumberForComputation = 0;
        private double Inputing;
        private int ArithmeticExpression = 0;
        private bool NumberInputing = false;
        private double Buffer = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Comput(int x)
        {
            if (NewNumber)
            {
                TextForInput.Text = "";
                NewNumber = false;
            }
            TextForInput.Text += x.ToString();
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            Comput(1);
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            Comput(2);
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            Comput(3);
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            Comput(4);
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            Comput(5);
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            Comput(6);
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            Comput(7);
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            Comput(8);
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            Comput(9);
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            Comput(0);
        }

        private void ButtonDelLastNam_Click(object sender, EventArgs e)
        {
            TextForInput.Text = "0";
            NewNumber = true;
        }

        private void ButtonDelAll_Click(object sender, EventArgs e)
        {
            TextForInput.Text = "0";
            TextForComputation.Text = "";
            NewNumber = true;
            NumberInputing = false;
            ArithmeticExpression = 0;
        }

        private void ButtonDelSymbol_Click(object sender, EventArgs e)
        {
            if (TextForInput.Text.Length == 1)
            {
                TextForInput.Text = "0";
                NewNumber = true;
            }
            else
            {
                TextForInput.Text = TextForInput.Text.Remove(TextForInput.Text.Length - 1);
            }

        }

        private void ButtonCom_Click(object sender, EventArgs e)
        {
            if (!TextForInput.Text.Contains(','))
            {
                TextForInput.Text += ',';
                NewNumber = false;
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Inputing = Convert.ToDouble(TextForInput.Text);
            if (NumberInputing == false)
            {
                NumberForComputation = Convert.ToDouble(TextForInput.Text);
            }
            TextForComputation.Text = NumberForComputation.ToString() + '+';
            TextForInput.Text = Inputing.ToString();
            NewNumber = true;
            NumberInputing = true;
            ArithmeticExpression = 1;
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Inputing = Convert.ToDouble(TextForInput.Text);
            if (NumberInputing == false)
            {
                NumberForComputation = Convert.ToDouble(TextForInput.Text);
            }
            TextForComputation.Text = NumberForComputation.ToString() + '-';
            TextForInput.Text = Inputing.ToString();
            NewNumber = true;
            NumberInputing = true;
            ArithmeticExpression = 2;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Inputing = Convert.ToDouble(TextForInput.Text);
            if (NumberInputing == false)
            {
                NumberForComputation = Convert.ToDouble(TextForInput.Text);
            }
            TextForComputation.Text = NumberForComputation.ToString() + "×";
            TextForInput.Text = Inputing.ToString();
            NewNumber = true;
            NumberInputing = true;
            ArithmeticExpression = 3;
        }

        private void ButtonSplitUp_Click(object sender, EventArgs e)
        {
            Inputing = Convert.ToDouble(TextForInput.Text);
            if (NumberInputing == false)
            {
                NumberForComputation = Convert.ToDouble(TextForInput.Text);
            }
            TextForComputation.Text = NumberForComputation.ToString() + "÷";
            TextForInput.Text = Inputing.ToString();
            NewNumber = true;
            NumberInputing = true;
            ArithmeticExpression = 4;
        }

        private void ButtonNumberMinusTheFirstDegree_Click(object sender, EventArgs e)
        {
            TextForComputation.Text = NumberForComputation.ToString();
            if (NumberForComputation == 0)
            {
                TextForComputation.Text = "∞";
                NumberForComputation = 0;
                Inputing = 0;
            }
            else
            {
                NumberForComputation = 1 / NumberForComputation;
            }
            if (ArithmeticExpression == 1)
            {
                TextForComputation.Text += '+';
            }
            else if (ArithmeticExpression == 2)
            {
                TextForComputation.Text += '-';
            }
            else if (ArithmeticExpression == 3)
            {
                TextForComputation.Text += '×';
            }
            else if (ArithmeticExpression == 4)
            {
                TextForComputation.Text += '÷';
            }
            Inputing = Convert.ToDouble(TextForInput.Text);
            TextForInput.Text = Inputing.ToString();
            NewNumber = true;
            NumberInputing = true;
        }

        private void ButtonDegree_Click(object sender, EventArgs e)
        {
            if ((TextForComputation.Text != "NaN") && (TextForComputation.Text != "∞") && (NumberInputing = true))
            {
                NumberForComputation = NumberForComputation * NumberForComputation;
                TextForComputation.Text = NumberForComputation.ToString();
                if (ArithmeticExpression == 1)
                {
                    TextForComputation.Text += '+';
                }
                else if (ArithmeticExpression == 2)
                {
                    TextForComputation.Text += '-';
                }
                else if (ArithmeticExpression == 3)
                {
                    TextForComputation.Text += '×';
                }
                else if (ArithmeticExpression == 4)
                {
                    TextForComputation.Text += '÷';
                }
            }
            else
            {
                TextForComputation.Text = "NaN";
                NumberForComputation = 0;
                Inputing = 0;
                TextForInput.Text = "0";
            }
            Inputing = Convert.ToDouble(TextForInput.Text);
            NumberInputing = true;
            NewNumber = true;
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            if (NumberForComputation > 0)
            {
                NumberForComputation = Convert.ToDouble(Math.Sqrt(NumberForComputation));
                TextForComputation.Text = NumberForComputation.ToString();
                if (ArithmeticExpression == 1)
                {
                    TextForComputation.Text += '+';
                }
                else if (ArithmeticExpression == 2)
                {
                    TextForComputation.Text += '-';
                }
                else if (ArithmeticExpression == 3)
                {
                    TextForComputation.Text += '×';
                }
                else if (ArithmeticExpression == 4)
                {
                    TextForComputation.Text += '÷';
                }
            }
            else
            {
                TextForComputation.Text = "NaN";
                NumberForComputation = 0;
                Inputing = 0;
                TextForInput.Text = "0";
            }
            Inputing = Convert.ToDouble(TextForInput.Text);
            NumberInputing = true;
            NewNumber = true;
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            Inputing = Convert.ToDouble(TextForInput.Text);
            if (NumberInputing == false)
            {
                NumberForComputation = Convert.ToDouble(TextForInput.Text);
            }
            TextForComputation.Text = NumberForComputation.ToString() + "%";
            TextForInput.Text = Inputing.ToString();
            NewNumber = true;
            NumberInputing = true;
            ArithmeticExpression = 5;

        }

        private void ButtonEqually_Click(object sender, EventArgs e)
        {
            Inputing = Convert.ToDouble(TextForInput.Text);
            if (ArithmeticExpression == 0)
            {
                NumberForComputation = Convert.ToDouble(TextForInput.Text);
            }
            else if (ArithmeticExpression == 1)
            {
                NumberForComputation += Inputing;
            }
            else if (ArithmeticExpression == 2)
            {
                NumberForComputation -= Inputing;
            }
            else if (ArithmeticExpression == 3)
            {
                NumberForComputation *= Inputing;
            }
            else if (ArithmeticExpression == 4)
            {
                if (Inputing == 0)
                {
                    TextForComputation.Text = "∞";
                    NumberForComputation = 0;
                    Inputing = 0;
                }
                else
                {
                    NumberForComputation = NumberForComputation/Inputing;
                }
            }
            else
            {
                if (Inputing > 0)
                {
                    NumberForComputation = NumberForComputation % Inputing;
                    TextForComputation.Text = NumberForComputation.ToString();
                }
                else
                {
                    TextForComputation.Text = "NaN";
                    NumberForComputation = 0;
                    Inputing = 0;
                }
            }
            if ((TextForComputation.Text != "∞") && (TextForComputation.Text != "NaN"))
            {
                TextForComputation.Text = NumberForComputation.ToString();
                NumberInputing = true;
            }
            else
            {
                NumberInputing = false;
            }
            Inputing = 0;
            TextForInput.Text = "0";
            NewNumber = true;
            ArithmeticExpression = 0;
        }

        private void ButtonChangeSign_Click(object sender, EventArgs e)
        {
            NumberForComputation *= -1;
            TextForComputation.Text = NumberForComputation.ToString();
            if (ArithmeticExpression == 1)
            {
                TextForComputation.Text += '+';
            }
            else if (ArithmeticExpression == 2)
            {
                TextForComputation.Text += '-';
            }
            else if (ArithmeticExpression == 3)
            {
                TextForComputation.Text += '×';
            }
            else if (ArithmeticExpression == 4)
            {
                TextForComputation.Text += '÷';
            }
        }
        private void ButtonBufferMinus_Click(object sender, EventArgs e)
        {
            if (!NumberInputing)
            {
                Buffer -= Inputing;
            }
            else
            {
                Buffer -= NumberForComputation;
            }
        }

        private void ButtonBufferClear_Click(object sender, EventArgs e)
        {
            Buffer = 0;
        }

        private void ButtonBufferPlus_Click(object sender, EventArgs e)
        {
            if (!NumberInputing)
            {
                Buffer += Inputing;
            }
            else
            {
                Buffer += NumberForComputation;
            }
        }

        private void ButtonBufferWright_Click(object sender, EventArgs e)
        {
            TextForComputation.Text = Buffer.ToString();
            NumberForComputation = Buffer;
            NumberInputing = true;
        }

        private void ButtonBufferSave_Click(object sender, EventArgs e)
        {
            if (!NumberInputing)
            {
                Buffer = Inputing;
            }
            else
            {
                Buffer = NumberForComputation;
            }
        }
    }
}
