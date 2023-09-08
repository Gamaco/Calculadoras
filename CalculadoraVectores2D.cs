
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

        Physics physics = new Physics();

        public CalculadoraVectores2D()
        {
            InitializeComponent();
        }

        // Boton para sumar.
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (guardarInputDelUsuario() == -1) { return; }

            calcularAx();
            calcularAy();

            calcularBx();
            calcularBy();

            sumarVectores();
            conversion();
        }

        private void calcularAx()
        {
            Ax = physics.calcularComponenteX(Ar, Az);

            label19.Visible = true;
            label12.Text = "A(" + Ar.ToString() + "," + Az.ToString() + ")";
            label13.Text = "Ax = " + Ar.ToString() + " Cos " + Az.ToString() + " = " + Ax.ToString("F2"); // El parametro F2 es para mostrar solo dos posiciones decimales.
        }

        private void calcularAy()
        {
            Ay = physics.calcularComponenteY(Ar, Az);

            label14.Text = "Ay = " + Ar.ToString() + " Sen " + Az.ToString() + " = " + Ay.ToString("F2");
        }

        private void calcularBx()
        {
            Bx = physics.calcularComponenteX(Br, Bz);

            label20.Visible = true;
            label17.Text = "B(" + Br.ToString() + "," + Bz.ToString() + ")";
            label16.Text = "Bx = " + Br.ToString() + " Cos " + Bz.ToString() + " = " + Bx.ToString("F2");
        }

        private void calcularBy()
        {
            By = physics.calcularComponenteY(Br, Bz);

            label15.Text = "By = " + Br.ToString() + " Sen " + Bz.ToString() + " = " + By.ToString("F2");
        }

        private void sumarVectores()
        {
            label21.Visible = true;
            label22.Visible = true;

            rX = Ax + Bx; //cambie resultado X y Y a una variable global para utilizar en otra funcion.
            rY = Ay + By;

            lblResultadoSumaX.Text = "Rx = Ax + Bx = " + rX.ToString("F2");
            lblResultadoSumaY.Text = "Ry = Ay + By = " + rY.ToString("F2");

        }

        //La suma de vectores se van a utilizar para conseguir la magnitud y la longitud.
        private void conversion()
        {
            rA = physics.calcularMagitud(rX, rY);

            rZ = physics.calcularDireccion(rX, rY);

            lblResultadoA.Text = "Ra = " + rA.ToString("F2");

            lblResultadoZ.Text = "Rθ = " + rZ.ToString("F2");

            lblResultadoFinal.Text = "R = (" + rA.ToString("F2") + "," + rZ.ToString("F2") + ")";
        }

        #region Boton Para Hacer Reset
        // Boton para resetear variables y labels.
        private void btnBorrar_Click(object sender, EventArgs e)
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
            lblResultadoSumaX.Text = "";
            lblResultadoSumaY.Text = "";
            lblResultadoA.Text = "";
            lblResultadoZ.Text = "";
            lblResultadoFinal.Text = "";
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;

            Ax = 0; Bx = 0; Bz = 0; Az = 0; Ay = 0; By = 0; Ar = 0; Br = 0;
        }
        #endregion

        #region Obtener Valores Del Usuario
        // El proposito de este metodo es guardar el input del usuario en las variables globales.
        // Para obtener el input hay que convertir el valor de string a float con validación de datos, por si el 
        // usuario entra una letra o un caracter especial en ves de un valor numerico.
        private int guardarInputDelUsuario()
        {
            if (!TryParse(aRInput.Text, out Ar) ||
                !TryParse(aZInput.Text, out Az) ||
                !TryParse(bZInput.Text, out Bz) ||
                !TryParse(bRInput.Text, out Br))
            {
                return -1;
            }

            if (Ar == 0 && Az == 0 || Bz == 0 && Br == 0 || Ar < 0 || Az < 0 || Br < 0 || Bz < 0)
            {
                MessageBox.Show("Asegurese de no entrar valores negativos o vectores con dos 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

