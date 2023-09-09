namespace Calculadoras
{
    public partial class Calculadoras : Form
    {
        CalculadoraVectores2D calculadora2D = new CalculadoraVectores2D() { TopLevel = false, TopMost = true, Anchor = AnchorStyles.None, Dock = DockStyle.Fill};
        CalculadoraVectores3D calculadora3D = new CalculadoraVectores3D() { TopLevel = false, TopMost = true };

        public Calculadoras()
        {
            InitializeComponent();
            mostrarPantallaDeVectores2D();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarPantallaDeVectores2D();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarPantallaDeVectores3D();
        }

        private void mostrarPantallaDeVectores2D()
        {
            calculadora3D.Hide();
            displayPanel.Controls.Add(calculadora2D);
            calculadora2D.Show();
            button3.BackColor = Color.FromArgb(38, 38, 38);
            button2.BackColor = Color.FromArgb(71, 71, 71);
            picIcon1.BackColor = button2.BackColor;
            picIcon2.BackColor = button3.BackColor;
        }

        private void mostrarPantallaDeVectores3D()
        {
            calculadora2D.Hide();
            displayPanel.Controls.Add(calculadora3D);
            calculadora3D.Show();
            button2.BackColor = Color.FromArgb(38, 38, 38);
            button3.BackColor = Color.FromArgb(71, 71, 71);
            picIcon1.BackColor = button2.BackColor;
            picIcon2.BackColor = button3.BackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}