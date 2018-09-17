using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades2;

namespace LaCalculadora
{
    public partial class LaCalculador : Form
    {
        public LaCalculador()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            double resultadoss = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            if (resultadoss!= ' ')
            {
                lblResultado.Text = Convert.ToString(resultadoss);
            }
            
        }

    private double Operar(string numero1, string numero2, string operador)
        {
            double num1, num2;
            double resultadoss = ' ';

            if (double.TryParse(numero1, out num1))
            {
                if (double.TryParse(numero2, out num2))
                {
                    if (num1 == 0 && operador == "/")
                    {
                       
                        lblResultado.Text = "Imposible Dividir";                        
                    }
                    else
                    {
                        Numero valor1 = new Numero(num1);
                        Numero valor2 = new Numero(num2);

                        resultadoss = Calculadora.Operar(valor1, valor2, operador);
                     }
                }
                else
                {
                    txtNumero2.Text = "";
                }

            }
            else
            {
                txtNumero1.Text = "";
                txtNumero2.Text = "";
            }
            return resultadoss;
        }


        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "0";
            cmbOperador.Text = "";
        }



         /// <summary>
         /// cierra la aplicacion
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnConvertirBinario_Click(object sender, EventArgs e)
        {
             string resultadoss ;
            if (lblResultado.Text != " ")
            {
                resultadoss = Numero.DecimalBinario(lblResultado.Text);
                lblResultado.Text = Convert.ToString(resultadoss);
            }
  
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoss;
            if (lblResultado.Text!=" ")
            {
                resultadoss = Numero.BinarioDecimal(lblResultado.Text);
                lblResultado.Text = resultadoss;

            }
          
        }
    }
}
