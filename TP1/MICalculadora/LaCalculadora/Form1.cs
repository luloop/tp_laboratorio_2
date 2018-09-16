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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double num1; //lee
            double num2; // lee
            double resultadoss = 0;
            string operador = cmbOperador.Text;

            if (double.TryParse(txtNumero1.Text, out num1))
            {
                if (double.TryParse(txtNumero2.Text, out num2))
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

                        lblResultado.Text = Convert.ToString(resultadoss);
                    }
                    
                }

            }
           
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "-";
            txtNumero2.Text = "-";
            lblResultado.Text = "0";
            

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
                                        
               resultadoss = Numero.DecimalBinario (txtNumero1.Text);
               lblResultado.Text = Convert.ToString(resultadoss);
                    

              

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoss;
            resultadoss = Numero.BinarioDecimal(txtNumero1.Text);
            lblResultado.Text =resultadoss;
        }
    }
}
