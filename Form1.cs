using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Operaciones obj = new Operaciones();

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            if(!obj.IsNumeric(txtnum1.Text) && !obj.IsNumeric(txtnum2.Text))
            {
                txtresultado.Text = "INGRESE UN VALOR VALIDO";
            }
            else
            {
                int suma = obj.Suma(Convert.ToInt32(txtnum1.Text), Convert.ToInt32(txtnum2.Text));
                txtresultado.Text = Convert.ToString(suma);
            }
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(txtnum1.Text) && !obj.IsNumeric(txtnum2.Text))
            {
                txtresultado.Text = "INGRESE UN VALOR VALIDO";
            }
            else
            {
                int resta = obj.resta(Convert.ToInt32(txtnum1.Text), Convert.ToInt32(txtnum2.Text));
                txtresultado.Text = Convert.ToString(resta);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(txtnum1.Text) && !obj.IsNumeric(txtnum2.Text))
            {
                txtresultado.Text = "INGRESE UN VALOR VALIDO";
            }
            else
            {
                int division = obj.division(Convert.ToInt32(txtnum1.Text), Convert.ToInt32(txtnum2.Text));
                txtresultado.Text = Convert.ToString(division);
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(txtnum1.Text) && !obj.IsNumeric(txtnum2.Text))
            {
                txtresultado.Text = "INGRESE UN VALOR VALIDO";
            }
            else
            {
                int multiplicar = obj.multiplicar(Convert.ToInt32(txtnum1.Text), Convert.ToInt32(txtnum2.Text));
                txtresultado.Text = Convert.ToString(multiplicar);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
