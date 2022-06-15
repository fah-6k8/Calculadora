using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string input = "0";
        string operador1 = string.Empty;
        string operador2 = string.Empty;
        char operacao = ' ';
        double resultado = 0.0;
        bool vizualizador = true;
        

        public Form1()
        {
            InitializeComponent();
        }

        public void Test()
        {            
            if (vizualizador)
            {
                input = string.Empty;
                vizualizador = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Test();
            input += "0";
            txtLog.Text = input;
        }

        private void digt1_Click(object sender, EventArgs e)
        {
            Test();
            input += "1";
            txtLog.Text = input;
        }

        private void digt2_Click(object sender, EventArgs e)
        {
            Test();
            input += "2";
            txtLog.Text = input;
        }

        private void digt3_Click(object sender, EventArgs e)
        {
            Test();
            input += "3";
            txtLog.Text = input;
        }

        private void digt4_Click(object sender, EventArgs e)
        {
            Test();
            input += "4";
            txtLog.Text = input;
        }

        private void digt5_Click(object sender, EventArgs e)
        {
            Test();
            input += "5";
            txtLog.Text = input;
        }

        private void digt6_Click(object sender, EventArgs e)
        {
            Test();
            input += "6";
            txtLog.Text = input;
        }

        private void digt7_Click(object sender, EventArgs e)
        {
            Test();
            input += "7";
            txtLog.Text = input;
        }

        private void digt8_Click(object sender, EventArgs e)
        {
            Test();
            input += "8";
            txtLog.Text = input;
        }

        private void digt9_Click(object sender, EventArgs e)
        {
            Test();
            input += "9";
            txtLog.Text = input;
        }

        private void Ponto_Click(object sender, EventArgs e)
        {
            if(input == "0")
            {
                vizualizador = false;
            }
            else
            {
                Test();
            }
            input += ".";
            txtLog.Text = input;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if (!(operacao == ' '))
            {
                operador2 = input;
                igual_oper();
                input = resultado.ToString();
                vizualizador = true;
                txtLog.Text = input;

            }
        }

        private void igual_oper()
        {
            if(operacao == '+')
            {
                resultado = Convert.ToDouble(operador1) + Convert.ToDouble(operador2);
            }
            if (operacao == '-')
            {
                resultado = Convert.ToDouble(operador1) - Convert.ToDouble(operador2);
            }
            if (operacao == '*')
            {
                resultado = Convert.ToDouble(operador1) * Convert.ToDouble(operador2);
            }
            if (operacao == '/')
            {
                resultado = Convert.ToDouble(operador1) / Convert.ToDouble(operador2);
            }
            if (operacao == '^')
            {
                resultado = Math.Pow( Convert.ToDouble(operador1) , Convert.ToDouble(operador2));
            }
            if (operacao == '#')
            {
                resultado = Math.Pow(Convert.ToDouble(operador1), 1/Convert.ToDouble(operador2));
            }
        }

        private void Raiz_Click_1(object sender, EventArgs e)
        {
            if (operacao == ' ')
            {
                operador1 = input;
                operacao = '#';
                vizualizador = true;
            }
            else
            {
                operador2 = input;
                igual_oper();
                operador1 = resultado.ToString();
                operacao = '#';
                txtLog.Text = operador1;
                vizualizador = true;
            }
        }

        private void Exponencial_Click(object sender, EventArgs e)
        {
            if (operacao == ' ')
            {
                operador1 = input;
                operacao = '^';
                vizualizador = true;
            }
            else
            {
                operador2 = input;
                igual_oper();
                operador1 = resultado.ToString();
                operacao = '^';
                txtLog.Text = operador1;
                vizualizador = true;
            }
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            if (operacao == ' ')
            {
                operador1 = input;
                operacao = '/';
                vizualizador = true;
            }
            else
            {
                operador2 = input;
                igual_oper();
                operador1 = resultado.ToString();
                operacao = '/';
                txtLog.Text = operador1;
                vizualizador = true;
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            input = "0";
            operador1 = string.Empty;
            operador2 = string.Empty;
            operacao = ' ';
            resultado = 0.0;
            vizualizador = true;
            txtLog.Text = input;
        }

        private void Muntiplicar_Click(object sender, EventArgs e)
        {
            if (operacao == ' ')
            {
                operador1 = input;
                operacao = '*';
                vizualizador = true;
            }
            else
            {
                operador2 = input;
                igual_oper();
                operador1 = resultado.ToString();
                operacao = '*';
                txtLog.Text = operador1;
                vizualizador = true;
            }
        }

        private void Subtrair_Click(object sender, EventArgs e)
        {
            if (operacao == ' ')
            {
                operador1 = input;
                operacao = '-';
                vizualizador = true;
            }
            else
            {
                operador2 = input;
                igual_oper();
                operador1 = resultado.ToString();
                operacao = '-';
                txtLog.Text = operador1;
                vizualizador = true;
            }
        }

       

        private void Somar_Click(object sender, EventArgs e)
        {
            if (operacao == ' ')
            {
                operador1 = input;
                operacao = '+';
                vizualizador = true;
            }
            else
            {
                operador2 = input;
                igual_oper();
                operador1 = resultado.ToString();
                operacao = '+';
                txtLog.Text = operador1;
                vizualizador = true;
            }
        }


    }
}
