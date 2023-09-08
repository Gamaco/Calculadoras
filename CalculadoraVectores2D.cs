﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private float rX;
        private float rY;

        private float rZ;
        private float rA;

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
            conversion();
            quadrants();
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

            rX = Ax + Bx; //cambie resultado X y Y a una variable global para utilizar en otra funcion.
            rY = Ay + By;

            lblResultadoFinal.Text = "R = (" + rX.ToString("F2") + "," + rY.ToString("F2") + ")";
        }

        private float valorEnRadianes(float numero)
        {
            return (float)(numero * (Math.PI / 180.0));
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

            if (Ar == 0 && Az == 0 || Bz == 0 && Br == 0 || Ar < 0 || Az < 0 || Br < 0 || Bz < 0)
            {
                MessageBox.Show("Asegurese de no entrar valores negativos o vectores con dos 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {

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
            lblRConversion.Text = "";
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;

            Ax = 0; Bx = 0; Bz = 0; Az = 0; Ay = 0; By = 0; Ar = 0; Br = 0;
        }

        //La suma de vectores se van a utilizar para conseguir la magnitud y la longitud.
        private void conversion()
        {
            rA = MathF.Sqrt(rX * rX + rY * rY);

            rZ = MathF.Atan(rY / rX);
        }

        //Verifica en que cuadrante estan nuestra magnitud y longitud.
        private void quadrants()
        {
            switch (rA, rZ)
            {
                case ( > 0, > 0): // rA y rZ son positos. Van en el primer cuadrante.
                    {
                        lblRConversion.Text = "RA + RB = (" + rA.ToString("F2") + ", " + rZ.ToString("F2") + ")";
                        break;
                    }


            }

        }
    }
}
