using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;
            //1
            if((string.IsNullOrEmpty(primerText.Text))|string.IsNullOrEmpty(segundoText.Text) | string.IsNullOrEmpty(tercertext.Text))
            {

                /*2*/ MessageBox.Show("Uno o mas campos estan vacios, intente de nuevo completando correctamente todos los campos del programa",
                          "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           /*3*/ else
            {
                n1 = int.Parse(primerText.Text);
                n2 = int.Parse(segundoText.Text);
                n3 = int.Parse(tercertext.Text);

                /*4*/ if(n1<= 0|n2<= 0 | n3 <= 0)
                {
                    /*5*/
                    MessageBox.Show("Los valores ingresados en los campos deben ser mayores que cero, intente de nuevo cumpliendo con el requisito mencionado.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {        /*6*/          /*7*/
                    if ((n1 == n2) && (n2 == n3))
                    {
                       /*8*/ Resultado.Text = "Las longitudes digitadas pertenecen a un triangulo Equilaptero";

                    }/*9*/ else if ((n1 == n2) | (n1 == n3) | (n2 == n3)) {

                       /*10*/ Resultado.Text = "Las longitudes digitadas pertenecen a un triangulo Isosceles";
                    }
                 /*11*/   else
                    {
                       /*12*/ Resultado.Text = "Las longitudes digitadas pertenecen a un triangulo Escaleno";
                    }
                }
            }

        }
    }
}
