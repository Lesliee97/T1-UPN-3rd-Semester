using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static T1_fundamentos.Operador;
using static T1_fundamentos.Operador.Multiply;

namespace T1_fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void real1_KeyUp(object sender, KeyEventArgs e)
        {
            //Usando expreiones regulares para  validar numeros reales
            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(real1.Text))
            {
                errorProvider1.SetError(real1, String.Empty);
            }
            else
            {
                errorProvider1.SetError(real1,
                      "Ingresar solo números");
            }
        }
        private void real2_KeyUp(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(real2.Text))
            {
                errorProvider1.SetError(real2, String.Empty);
            }
            else
            {
                errorProvider1.SetError(real2,
                      "Ingresar solo números");
            }
        }

        private void imag1_KeyUp(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(imag1.Text))
            {
                errorProvider1.SetError(imag1, String.Empty);
            }
            else
            {
                
                errorProvider1.SetError(imag1,
                      "Ingresar solo números");
               
            }
        }

        private void imag2_KeyUp(object sender, KeyEventArgs e)
        {
            Regex regex = new Regex("^-?[0-9]+([.])?([0-9]+)?$");
            if (regex.IsMatch(imag2.Text))
            {
                errorProvider1.SetError(imag2, String.Empty);
            }
            else
            {
                errorProvider1.SetError(imag2,
                      "Ingresar solo números");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //ADDITION
            Sum s1 = new Sum();

            Sum s2 = new Sum();

            Sum sum = new Sum();

            s1.real = double.Parse(real1.Text);
            s1.imag = double.Parse(imag1.Text);
            s2.real = double.Parse(real2.Text);
            s2.imag = double.Parse(imag2.Text);

            sum = s1 + s2;

            realAdd.Text = sum.real.ToString();
            imagAdd.Text = sum.imag.ToString();


            //SUBTRACTION
            Resta r1 = new Resta();

            Resta r2 = new Resta();

            Resta resta = new Resta();

            r1.real = double.Parse(real1.Text);
            r1.imag = double.Parse(imag1.Text);
            r2.real = double.Parse(real2.Text);
            r2.imag = double.Parse(imag2.Text);

            resta = r1 + r2;

            realRest.Text = resta.real.ToString();
            imagRest.Text = resta.imag.ToString();


            // MULTIPLICATION
            Multiply m1 = new Multiply();

            Multiply m2 = new Multiply();

            Multiply multi = new Multiply();

            m1.real = double.Parse(real1.Text);
            m1.imag = double.Parse(imag1.Text);
            m2.real = double.Parse(real2.Text);
            m2.imag = double.Parse(imag2.Text);

            multi = m1 * m2;

            realMult.Text = multi.real.ToString();
            imagMult.Text = multi.imag.ToString();

            // DIVISION
            Div d1 = new Div();

            Div d2 = new Div();

            Div div = new Div();

            d1.real = double.Parse(real1.Text);
            d1.imag = double.Parse(imag1.Text);
            d2.real = double.Parse(real2.Text);
            d2.imag = double.Parse(imag2.Text);

            div = d1 / d2;

            realDiv.Text = div.real.ToString();
            imagDiv.Text = div.imag.ToString();
        }



        private void btnClean_Click(object sender, EventArgs e)
        {
            // Recorrer todos los controles del formulario
            foreach (Control c in this.Controls)
            {

                // Si es un texbox que lo "limpie"
                if (c is TextBox)

                {

                    c.Text = "";

                    //Enfoco en el primer TextBox

                    this.real1.Focus();

                }

            }

        }
    }
}


