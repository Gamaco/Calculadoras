using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class CalculadoraVectores3D : Form
    {
        private float Ar;
        private float Azeta;

        private float Br;
        private float Bzeta;

        private float Ax;
        private float Bx;

        private float By;
        private float Ay;

        private float AzA;
        private float BzA;

        private float rX;
        private float rY;

        private float rZ;
        private float rA;
        private float rAlfa;

        private Boolean operacion;

        Physics3D physics = new Physics3D();

        public CalculadoraVectores3D()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            if (guardarInputDelUsuario() == -1) { return; }

            calcularAx();
            calcularAy();
            calcularAz();

            calcularBx();
            calcularBy();
            calcularBz();

            sumaORestDeVectores();
            conversion();
        }

        #region Guardar Input Del Usuario
        private int guardarInputDelUsuario()
        {
            if (!TryParse(aRInput.Text, out Ar) ||
                !TryParse(aZInput.Text, out Azeta) ||
                !TryParse(bZInput.Text, out Bzeta) ||
                !TryParse(bRInput.Text, out Br) ||
                !TryParse(tbAZAlfaInput.Text, out AzA) ||
                !TryParse(tbBZAlfaInput.Text, out BzA))
            {
                return -1;
            }

            if (Ar == 0 || Br == 0 || Ar < 0 || Azeta < 0 || Br < 0 || Bzeta < 0)
            {
                MessageBox.Show("Asegurese de no entrar valores negativos o vectores con dos 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            else if (0 <= AzA && AzA <= 180 || 0 <= BzA && BzA <= 180)
            {
                MessageBox.Show("Asegurese que el alfa no sea menor de 0 o mayor de 180.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            return 1;
        }

        private bool TryParse(string input, out float output)
        {
            if (float.TryParse(input, out output))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Asegurese de entrar un valor numerico. No puede incluir letras, caracteres especiales o vacio sin valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        #endregion

        private void calcularAx()
        {
            Ax = physics.calcularComponenteX(Ar, Azeta); //,Az

            label26.Visible = true;
            lblValoresUsadosA.Text = "A(" + Ar.ToString() + "," + Azeta.ToString() + "," + AzA.ToString() + ")";
            lblResultadoAX.Text = "Ax = " + Ar.ToString() + " Cos " + Azeta.ToString() + " = " + Ax.ToString("F2"); // El parametro F2 es para mostrar solo dos posiciones decimales.
        }

        private void calcularAy()
        {
            Ay = physics.calcularComponenteY(Ar, Azeta); //,Az

            lblResultadoAY.Text = "Ay = " + Ar.ToString() + " Sen " + Azeta.ToString() + " = " + Ay.ToString("F2");
        }

        private void calcularAz()
        {
            Az = physics.calcularComponenteZ(Ar, Azeta, Az);

            lblResultadoAz.Text = "Az = " + Ar.ToString() + " Cos " + AzA.ToString() + " = " + AzA.ToString("F2");
        }

        private void calcularBx()
        {
            Bx = physics.calcularComponenteX(Br, Bzeta); //, Bz

            label25.Visible = true;
            lblValoresUsadosB.Text = "B(" + Br.ToString() + "," + Bzeta.ToString() + ")";
            lblResultadoBX.Text = "Bx = " + Br.ToString() + " Cos " + Bzeta.ToString() + " = " + Bx.ToString("F2");
        }

        private void calcularBy()
        {
            By = physics.calcularComponenteY(Br, Bzeta); //, Bz

            lblResultadoBZ.Text = "By = " + Br.ToString() + " Sen " + Bzeta.ToString() + " = " + By.ToString("F2");
        }

        private void calcularBz()
        {
            //By = physics.calcularComponenteY(Br, Bzeta, Bz);

            lblResultadoBZ.Text = "Bz = " + Br.ToString() + " Cos " + Bzeta.ToString() + " = " + BzA.ToString("F2");
        }

        //La suma de vectores se van a utilizar para conseguir la magnitud y la longitud.
        private void conversion()
        {
            rA = physics.calcularMagitud(rX, rY); //, rAlfa

            rZ = physics.calcularDireccion(rX, rY); //, rAlfa

            //rAlfa = physics.calcularAngulo(rX, rY, rAlfa);

            lblResultadoA.Text = "Ra = " + rA.ToString("F2");

            lblResultadoZ.Text = "Rθ = " + rZ.ToString("F2");

            lblResultadoAlfa.Text = "Ra = " + rAlfa.ToString("F2");

            lblVectorR.Text = "R = (" + rA.ToString("F2") + "," + rZ.ToString("F2") + "," + rAlfa.ToString() + ")";
        }
        private void sumaORestDeVectores()
        {

            if (operacion == true) //Anadir operacion para rZ
            {
                rX = Ax - Bx;
                rY = Ay - By;
            }
            else
            {
                rX = Ax + Bx;
                rY = Ay + By;
            }
            lblResultadoSumaX.Text = "Rx = Ax - Bx = " + rX.ToString("F2");
            lblResultadoSumaY.Text = "Ry = Ay - By = " + rY.ToString("F2");

            label29.Visible = true;
            label28.Visible = true;
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            operacion = (operacion == true) ? false : true;

            btnOperacion.Text = (operacion == true) ? "-" : "+";
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            lblValoresUsadosA.Text = "";
            lblResultadoAX.Text = "";
            lblResultadoAY.Text = "";
            lblResultadoAz.Text = "";
            lblValoresUsadosB.Text = "";
            lblResultadoBX.Text = "";
            lblResultadoBY.Text = "";
            lblResultadoAz.Text = "";
            aRInput.Text = "";
            aZInput.Text = "";
            bRInput.Text = "";
            bZInput.Text = "";
            tbAZAlfaInput.Text = "";
            tbBZAlfaInput.Text = "";
            lblRX.Text = "";
            lblRY.Text = "";
            lblRMagnitud.Text = "";
            lblRθ.Text = "";
            lblResultadoAlfa.Text = "";
            lblVectorR.Text = "";
            label26.Visible = false;
            label25.Visible = false;
            label29.Visible = false;
            label28.Visible = false;

            Ax = 0; Bx = 0; Bzeta = 0; Azeta = 0; AzA = 0; BzA = 0; Ay = 0; By = 0; Ar = 0; Br = 0;
        }

    }
}
