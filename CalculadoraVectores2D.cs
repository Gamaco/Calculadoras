using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class CalculadoraVectores2D : Form
    {
        private float Ar;
        private float Az;

        private float Br;
        private float Bz;

        private float Ax;
        private float Bx;

        private float By;
        private float Ay;

        public CalculadoraVectores2D()
        {
            InitializeComponent();
        }

        // Boton para sumar.
        private void button1_Click(object sender, EventArgs e)
        {
            guardarInputDelUsuario();

            calcularAx();
            calcularAy();

            calcularBx();
            calcularBy();

            sumarVectores();
        }

        private void calcularAx()
        {
            /* 
              Formula para obtener x es
                    x = r cos θ
            */

            Ax = (float)(Ar * Math.Cos(valorEnRadianes(Az)));

            label19.Visible = true;
            label12.Text = "A(" + Ar.ToString() + "," + Az.ToString() + ")";
            label13.Text = "Ax = " + Ar.ToString() + " Cos " + Az.ToString() + " = " + Ax.ToString("F2");
        }

        private void calcularAy()
        {
            /* 
              Formula para obtener y es
                    y = r sen θ
            */

            Ay = (float)(Ar * Math.Sin(valorEnRadianes(Az)));

            label14.Text = "Ay = " + Ar.ToString() + " Sen " + Az.ToString() + " = " + Ay.ToString("F2");
        }

        private void calcularBx()
        {
            Bx = (float)(Br * Math.Cos(valorEnRadianes(Bz)));
            
            label20.Visible = true;
            label17.Text = "B(" + Br.ToString() + "," + Bz.ToString() + ")";
            label16.Text = "Bx = " + Br.ToString() + " Cos " + Bz.ToString() + " = " + Bx.ToString("F2"); // El parametro F2 es para mostrar solo dos posiciones decimales.
        }

        private void calcularBy()
        {
            By = (float)(Br * Math.Sin(valorEnRadianes(Bz)));

            label15.Text = "By = " + Br.ToString() + " Sen " + Bz.ToString() + " = " + By.ToString("F2");
        }

        private void sumarVectores()
        {
            label21.Visible = true;
            label22.Visible = true;

            float resultadoX = Ax + Bx;
            float resultadoY = Ay + By;

            lblResultadoFinal.Text = "R = (" + resultadoX.ToString("F2") + "," + resultadoY.ToString("F2") + ")";
        }

        private float valorEnRadianes(float numero)
        {
            return (float) (numero * (Math.PI / 180.0));
        }

        #region Obtener Valores Del Usuario
        // El proposito de este metodo es guardar el input del usuario en las variables globales: Ar, Az, Br, Bz.
        // Para obtener el input hay que convertir el valor de string a float con validación de datos, por si el 
        // usuario entra una letra o un caracter especial en ves de un valor numerico por equivocación.
        private void guardarInputDelUsuario()
        {
            if (float.TryParse(aRInput.Text, out float Ar))
            {
                this.Ar = Ar;
            }
            else
            {
                MessageBox.Show("Asegurese de entrar un valor numerico. No puede incluir letras, caracteres especiales o vacio sin valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (float.TryParse(aZInput.Text, out float Az))
            {
                this.Az = Az;
            }
            else
            {
                MessageBox.Show("Asegurese de entrar un valor numerico. No puede incluir letras, caracteres especiales o vacio sin valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (float.TryParse(bZInput.Text, out float Bz))
            {
                this.Bz = Bz;
            }
            else
            {
                MessageBox.Show("Asegurese de entrar un valor numerico. No puede incluir letras, caracteres especiales o vacio sin valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (float.TryParse(bRInput.Text, out float Br))
            {
                this.Br = Br;
            }
            else
            {
                MessageBox.Show("Asegurese de entrar un valor numerico. No puede incluir letras, caracteres especiales o vacio sin valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        #endregion

        // Boton para resetear variables y labels.
        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label17.Text = "";
            label16.Text = "";
            label15.Text = "";
            aRInput.Text = "";
            aZInput.Text = "";
            bRInput.Text = "";
            bZInput.Text = "";
            lblResultadoFinal.Text = "";
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;

            Ax = 0; Bx = 0; Bz = 0; Az = 0; Ay = 0; By = 0; Ar = 0; Br = 0;
        }
    }
}
