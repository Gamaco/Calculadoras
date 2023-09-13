namespace Calculadoras
{
    partial class CalculadoraVectores3D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnResta = new Button();
            btnSuma = new Button();
            lblInstrucciones2 = new Label();
            lbl_instrucciones = new Label();
            aRInput = new TextBox();
            label3 = new Label();
            label9 = new Label();
            aZInput = new TextBox();
            bZInput = new TextBox();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            bRInput = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnBorrar = new Button();
            btnCalcular = new Button();
            lblResultadoFinal = new Label();
            lblResultadoZ = new Label();
            lblResultadoSumaY = new Label();
            lblResultadoA = new Label();
            lblResultadoSumaX = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            pblResultados = new Panel();
            lblResultadoAlfa = new Label();
            lblResultadoBZ = new Label();
            lblResultadoAz = new Label();
            lblVectorR = new Label();
            lblRθ = new Label();
            lblRY = new Label();
            lblRMagnitud = new Label();
            label28 = new Label();
            label29 = new Label();
            lblRX = new Label();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            label18 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            lblResultadoBY = new Label();
            lblResultadoBX = new Label();
            lblValoresUsadosB = new Label();
            lblResultadoAY = new Label();
            lblResultadoAX = new Label();
            lblValoresUsadosA = new Label();
            label34 = new Label();
            tbAZAlfaInput = new TextBox();
            tbBZAlfaInput = new TextBox();
            label35 = new Label();
            pblResultados.SuspendLayout();
            SuspendLayout();
            // 
            // btnResta
            // 
            btnResta.Location = new Point(481, 239);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(38, 29);
            btnResta.TabIndex = 83;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(481, 190);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(38, 29);
            btnSuma.TabIndex = 82;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // lblInstrucciones2
            // 
            lblInstrucciones2.Dock = DockStyle.Top;
            lblInstrucciones2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstrucciones2.ForeColor = Color.FromArgb(64, 64, 64);
            lblInstrucciones2.Location = new Point(0, 56);
            lblInstrucciones2.Name = "lblInstrucciones2";
            lblInstrucciones2.Size = new Size(999, 102);
            lblInstrucciones2.TabIndex = 81;
            lblInstrucciones2.Text = "R representa la magnitud.\r\nθ representa la dirección.\r\nα  representa el angulo.";
            lblInstrucciones2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_instrucciones
            // 
            lbl_instrucciones.Dock = DockStyle.Top;
            lbl_instrucciones.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_instrucciones.Location = new Point(0, 0);
            lbl_instrucciones.Name = "lbl_instrucciones";
            lbl_instrucciones.Size = new Size(999, 56);
            lbl_instrucciones.TabIndex = 80;
            lbl_instrucciones.Text = "Entre las coordenadas polares para los vectores A y B.\r\n";
            lbl_instrucciones.TextAlign = ContentAlignment.BottomCenter;
            // 
            // aRInput
            // 
            aRInput.Anchor = AnchorStyles.Top;
            aRInput.BackColor = SystemColors.ButtonFace;
            aRInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            aRInput.Location = new Point(115, 209);
            aRInput.Margin = new Padding(3, 4, 3, 4);
            aRInput.Name = "aRInput";
            aRInput.Size = new Size(65, 38);
            aRInput.TabIndex = 68;
            aRInput.TextAlign = HorizontalAlignment.Center;
            aRInput.WordWrap = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(187, 209);
            label3.Name = "label3";
            label3.Size = new Size(53, 40);
            label3.TabIndex = 69;
            label3.Text = ", θ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(946, 209);
            label9.Name = "label9";
            label9.Size = new Size(28, 40);
            label9.TabIndex = 79;
            label9.Text = ")";
            // 
            // aZInput
            // 
            aZInput.Anchor = AnchorStyles.Top;
            aZInput.BackColor = SystemColors.ButtonFace;
            aZInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            aZInput.Location = new Point(246, 209);
            aZInput.Margin = new Padding(3, 4, 3, 4);
            aZInput.Name = "aZInput";
            aZInput.Size = new Size(65, 38);
            aZInput.TabIndex = 70;
            aZInput.TextAlign = HorizontalAlignment.Center;
            aZInput.WordWrap = false;
            // 
            // bZInput
            // 
            bZInput.Anchor = AnchorStyles.Top;
            bZInput.BackColor = SystemColors.ButtonFace;
            bZInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bZInput.Location = new Point(732, 209);
            bZInput.Margin = new Padding(3, 4, 3, 4);
            bZInput.Name = "bZInput";
            bZInput.Size = new Size(65, 38);
            bZInput.TabIndex = 78;
            bZInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(447, 205);
            label4.Name = "label4";
            label4.Size = new Size(28, 40);
            label4.TabIndex = 71;
            label4.Text = ")";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Tomato;
            label8.Location = new Point(674, 209);
            label8.Name = "label8";
            label8.Size = new Size(53, 40);
            label8.TabIndex = 77;
            label8.Text = ", θ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(49, 178);
            label5.Name = "label5";
            label5.Size = new Size(40, 27);
            label5.TabIndex = 72;
            label5.Text = "⇀";
            // 
            // bRInput
            // 
            bRInput.Anchor = AnchorStyles.Top;
            bRInput.BackColor = SystemColors.ButtonFace;
            bRInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bRInput.Location = new Point(601, 209);
            bRInput.Margin = new Padding(3, 4, 3, 4);
            bRInput.Name = "bRInput";
            bRInput.Size = new Size(65, 38);
            bRInput.TabIndex = 76;
            bRInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(49, 209);
            label2.Name = "label2";
            label2.Size = new Size(60, 45);
            label2.TabIndex = 73;
            label2.Text = "A(r";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Tomato;
            label7.Location = new Point(532, 209);
            label7.Name = "label7";
            label7.Size = new Size(62, 43);
            label7.TabIndex = 75;
            label7.Text = "B(r";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(532, 178);
            label6.Name = "label6";
            label6.Size = new Size(40, 27);
            label6.TabIndex = 74;
            label6.Text = "⇀";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Top;
            btnBorrar.BackColor = Color.FromArgb(38, 38, 38);
            btnBorrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(246, 723);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(254, 51);
            btnBorrar.TabIndex = 85;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top;
            btnCalcular.BackColor = Color.FromArgb(38, 38, 38);
            btnCalcular.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(519, 723);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(254, 51);
            btnCalcular.TabIndex = 84;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultadoFinal
            // 
            lblResultadoFinal.Anchor = AnchorStyles.Top;
            lblResultadoFinal.AutoSize = true;
            lblResultadoFinal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoFinal.Location = new Point(703, 635);
            lblResultadoFinal.Name = "lblResultadoFinal";
            lblResultadoFinal.Size = new Size(0, 24);
            lblResultadoFinal.TabIndex = 100;
            // 
            // lblResultadoZ
            // 
            lblResultadoZ.Anchor = AnchorStyles.Top;
            lblResultadoZ.AutoSize = true;
            lblResultadoZ.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoZ.Location = new Point(703, 556);
            lblResultadoZ.Name = "lblResultadoZ";
            lblResultadoZ.Size = new Size(0, 23);
            lblResultadoZ.TabIndex = 99;
            // 
            // lblResultadoSumaY
            // 
            lblResultadoSumaY.Anchor = AnchorStyles.Top;
            lblResultadoSumaY.AutoSize = true;
            lblResultadoSumaY.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoSumaY.Location = new Point(703, 460);
            lblResultadoSumaY.Name = "lblResultadoSumaY";
            lblResultadoSumaY.Size = new Size(0, 23);
            lblResultadoSumaY.TabIndex = 98;
            // 
            // lblResultadoA
            // 
            lblResultadoA.Anchor = AnchorStyles.Top;
            lblResultadoA.AutoSize = true;
            lblResultadoA.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoA.Location = new Point(703, 520);
            lblResultadoA.Name = "lblResultadoA";
            lblResultadoA.Size = new Size(0, 23);
            lblResultadoA.TabIndex = 97;
            // 
            // lblResultadoSumaX
            // 
            lblResultadoSumaX.Anchor = AnchorStyles.Top;
            lblResultadoSumaX.AutoSize = true;
            lblResultadoSumaX.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoSumaX.Location = new Point(703, 424);
            lblResultadoSumaX.Name = "lblResultadoSumaX";
            lblResultadoSumaX.Size = new Size(0, 23);
            lblResultadoSumaX.TabIndex = 92;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(422, 460);
            label15.Name = "label15";
            label15.Size = new Size(0, 23);
            label15.TabIndex = 91;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(422, 424);
            label16.Name = "label16";
            label16.Size = new Size(0, 23);
            label16.TabIndex = 90;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Tomato;
            label17.Location = new Point(422, 365);
            label17.Name = "label17";
            label17.Size = new Size(0, 29);
            label17.TabIndex = 89;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(168, 460);
            label14.Name = "label14";
            label14.Size = new Size(0, 23);
            label14.TabIndex = 88;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(168, 424);
            label13.Name = "label13";
            label13.Size = new Size(0, 23);
            label13.TabIndex = 87;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.CornflowerBlue;
            label12.Location = new Point(168, 365);
            label12.Name = "label12";
            label12.Size = new Size(0, 29);
            label12.TabIndex = 86;
            // 
            // pblResultados
            // 
            pblResultados.Anchor = AnchorStyles.Top;
            pblResultados.BackColor = SystemColors.ButtonFace;
            pblResultados.BorderStyle = BorderStyle.FixedSingle;
            pblResultados.Controls.Add(lblResultadoAlfa);
            pblResultados.Controls.Add(lblResultadoBZ);
            pblResultados.Controls.Add(lblResultadoAz);
            pblResultados.Controls.Add(lblVectorR);
            pblResultados.Controls.Add(lblRθ);
            pblResultados.Controls.Add(lblRY);
            pblResultados.Controls.Add(lblRMagnitud);
            pblResultados.Controls.Add(label28);
            pblResultados.Controls.Add(label29);
            pblResultados.Controls.Add(lblRX);
            pblResultados.Controls.Add(label1);
            pblResultados.Controls.Add(label10);
            pblResultados.Controls.Add(label11);
            pblResultados.Controls.Add(label18);
            pblResultados.Controls.Add(label23);
            pblResultados.Controls.Add(label24);
            pblResultados.Controls.Add(label25);
            pblResultados.Controls.Add(label26);
            pblResultados.Controls.Add(label27);
            pblResultados.Controls.Add(lblResultadoBY);
            pblResultados.Controls.Add(lblResultadoBX);
            pblResultados.Controls.Add(lblValoresUsadosB);
            pblResultados.Controls.Add(lblResultadoAY);
            pblResultados.Controls.Add(lblResultadoAX);
            pblResultados.Controls.Add(lblValoresUsadosA);
            pblResultados.Location = new Point(116, 321);
            pblResultados.Margin = new Padding(3, 4, 3, 4);
            pblResultados.Name = "pblResultados";
            pblResultados.Size = new Size(770, 394);
            pblResultados.TabIndex = 101;
            // 
            // lblResultadoAlfa
            // 
            lblResultadoAlfa.Anchor = AnchorStyles.Top;
            lblResultadoAlfa.AutoSize = true;
            lblResultadoAlfa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoAlfa.Location = new Point(557, 267);
            lblResultadoAlfa.Name = "lblResultadoAlfa";
            lblResultadoAlfa.Size = new Size(0, 23);
            lblResultadoAlfa.TabIndex = 87;
            // 
            // lblResultadoBZ
            // 
            lblResultadoBZ.Anchor = AnchorStyles.Top;
            lblResultadoBZ.AutoSize = true;
            lblResultadoBZ.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoBZ.Location = new Point(272, 198);
            lblResultadoBZ.Name = "lblResultadoBZ";
            lblResultadoBZ.Size = new Size(0, 23);
            lblResultadoBZ.TabIndex = 86;
            // 
            // lblResultadoAz
            // 
            lblResultadoAz.Anchor = AnchorStyles.Top;
            lblResultadoAz.AutoSize = true;
            lblResultadoAz.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoAz.Location = new Point(18, 198);
            lblResultadoAz.Name = "lblResultadoAz";
            lblResultadoAz.Size = new Size(0, 23);
            lblResultadoAz.TabIndex = 85;
            // 
            // lblVectorR
            // 
            lblVectorR.Anchor = AnchorStyles.Top;
            lblVectorR.AutoSize = true;
            lblVectorR.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVectorR.Location = new Point(557, 333);
            lblVectorR.Name = "lblVectorR";
            lblVectorR.Size = new Size(0, 24);
            lblVectorR.TabIndex = 84;
            // 
            // lblRθ
            // 
            lblRθ.Anchor = AnchorStyles.Top;
            lblRθ.AutoSize = true;
            lblRθ.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRθ.Location = new Point(557, 234);
            lblRθ.Name = "lblRθ";
            lblRθ.Size = new Size(0, 23);
            lblRθ.TabIndex = 83;
            // 
            // lblRY
            // 
            lblRY.Anchor = AnchorStyles.Top;
            lblRY.AutoSize = true;
            lblRY.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRY.Location = new Point(557, 138);
            lblRY.Name = "lblRY";
            lblRY.Size = new Size(0, 23);
            lblRY.TabIndex = 82;
            // 
            // lblRMagnitud
            // 
            lblRMagnitud.Anchor = AnchorStyles.Top;
            lblRMagnitud.AutoSize = true;
            lblRMagnitud.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRMagnitud.Location = new Point(557, 198);
            lblRMagnitud.Name = "lblRMagnitud";
            lblRMagnitud.Size = new Size(0, 23);
            lblRMagnitud.TabIndex = 81;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top;
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(557, 43);
            label28.Name = "label28";
            label28.Size = new Size(129, 29);
            label28.TabIndex = 80;
            label28.Text = "Resultado";
            label28.Visible = false;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(553, 304);
            label29.Name = "label29";
            label29.Size = new Size(27, 29);
            label29.TabIndex = 79;
            label29.Text = "⇀";
            label29.Visible = false;
            // 
            // lblRX
            // 
            lblRX.Anchor = AnchorStyles.Top;
            lblRX.AutoSize = true;
            lblRX.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRX.Location = new Point(557, 102);
            lblRX.Name = "lblRX";
            lblRX.Size = new Size(0, 23);
            lblRX.TabIndex = 78;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(838, 335);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 77;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(838, 256);
            label10.Name = "label10";
            label10.Size = new Size(0, 23);
            label10.TabIndex = 76;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(838, 160);
            label11.Name = "label11";
            label11.Size = new Size(0, 23);
            label11.TabIndex = 75;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(838, 220);
            label18.Name = "label18";
            label18.Size = new Size(0, 23);
            label18.TabIndex = 74;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(838, 65);
            label23.Name = "label23";
            label23.Size = new Size(129, 29);
            label23.TabIndex = 73;
            label23.Text = "Resultado";
            label23.Visible = false;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(830, 304);
            label24.Name = "label24";
            label24.Size = new Size(27, 29);
            label24.TabIndex = 72;
            label24.Text = "⇀";
            label24.Visible = false;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Tomato;
            label25.Location = new Point(265, 38);
            label25.Name = "label25";
            label25.Size = new Size(27, 29);
            label25.TabIndex = 71;
            label25.Text = "⇀";
            label25.Visible = false;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.CornflowerBlue;
            label26.Location = new Point(13, 38);
            label26.Name = "label26";
            label26.Size = new Size(27, 29);
            label26.TabIndex = 70;
            label26.Text = "⇀";
            label26.Visible = false;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top;
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(838, 124);
            label27.Name = "label27";
            label27.Size = new Size(0, 23);
            label27.TabIndex = 69;
            // 
            // lblResultadoBY
            // 
            lblResultadoBY.Anchor = AnchorStyles.Top;
            lblResultadoBY.AutoSize = true;
            lblResultadoBY.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoBY.Location = new Point(272, 159);
            lblResultadoBY.Name = "lblResultadoBY";
            lblResultadoBY.Size = new Size(0, 23);
            lblResultadoBY.TabIndex = 68;
            // 
            // lblResultadoBX
            // 
            lblResultadoBX.Anchor = AnchorStyles.Top;
            lblResultadoBX.AutoSize = true;
            lblResultadoBX.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoBX.Location = new Point(272, 123);
            lblResultadoBX.Name = "lblResultadoBX";
            lblResultadoBX.Size = new Size(0, 23);
            lblResultadoBX.TabIndex = 67;
            // 
            // lblValoresUsadosB
            // 
            lblValoresUsadosB.Anchor = AnchorStyles.Top;
            lblValoresUsadosB.AutoSize = true;
            lblValoresUsadosB.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValoresUsadosB.ForeColor = Color.Tomato;
            lblValoresUsadosB.Location = new Point(272, 64);
            lblValoresUsadosB.Name = "lblValoresUsadosB";
            lblValoresUsadosB.Size = new Size(0, 29);
            lblValoresUsadosB.TabIndex = 66;
            // 
            // lblResultadoAY
            // 
            lblResultadoAY.Anchor = AnchorStyles.Top;
            lblResultadoAY.AutoSize = true;
            lblResultadoAY.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoAY.Location = new Point(18, 159);
            lblResultadoAY.Name = "lblResultadoAY";
            lblResultadoAY.Size = new Size(0, 23);
            lblResultadoAY.TabIndex = 65;
            // 
            // lblResultadoAX
            // 
            lblResultadoAX.Anchor = AnchorStyles.Top;
            lblResultadoAX.AutoSize = true;
            lblResultadoAX.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoAX.Location = new Point(18, 123);
            lblResultadoAX.Name = "lblResultadoAX";
            lblResultadoAX.Size = new Size(0, 23);
            lblResultadoAX.TabIndex = 64;
            // 
            // lblValoresUsadosA
            // 
            lblValoresUsadosA.Anchor = AnchorStyles.Top;
            lblValoresUsadosA.AutoSize = true;
            lblValoresUsadosA.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValoresUsadosA.ForeColor = Color.CornflowerBlue;
            lblValoresUsadosA.Location = new Point(18, 64);
            lblValoresUsadosA.Name = "lblValoresUsadosA";
            lblValoresUsadosA.Size = new Size(0, 29);
            lblValoresUsadosA.TabIndex = 63;
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top;
            label34.AutoSize = true;
            label34.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label34.ForeColor = Color.CornflowerBlue;
            label34.Location = new Point(320, 209);
            label34.Name = "label34";
            label34.Size = new Size(56, 40);
            label34.TabIndex = 102;
            label34.Text = ", α";
            // 
            // tbAZAlfaInput
            // 
            tbAZAlfaInput.Anchor = AnchorStyles.Top;
            tbAZAlfaInput.BackColor = SystemColors.ButtonFace;
            tbAZAlfaInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbAZAlfaInput.Location = new Point(382, 209);
            tbAZAlfaInput.Margin = new Padding(3, 4, 3, 4);
            tbAZAlfaInput.Name = "tbAZAlfaInput";
            tbAZAlfaInput.Size = new Size(65, 38);
            tbAZAlfaInput.TabIndex = 103;
            tbAZAlfaInput.TextAlign = HorizontalAlignment.Center;
            tbAZAlfaInput.WordWrap = false;
            // 
            // tbBZAlfaInput
            // 
            tbBZAlfaInput.Anchor = AnchorStyles.Top;
            tbBZAlfaInput.BackColor = SystemColors.ButtonFace;
            tbBZAlfaInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbBZAlfaInput.Location = new Point(875, 209);
            tbBZAlfaInput.Margin = new Padding(3, 4, 3, 4);
            tbBZAlfaInput.Name = "tbBZAlfaInput";
            tbBZAlfaInput.Size = new Size(65, 38);
            tbBZAlfaInput.TabIndex = 105;
            tbBZAlfaInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label35
            // 
            label35.Anchor = AnchorStyles.Top;
            label35.AutoSize = true;
            label35.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label35.ForeColor = Color.Tomato;
            label35.Location = new Point(816, 209);
            label35.Name = "label35";
            label35.Size = new Size(56, 40);
            label35.TabIndex = 104;
            label35.Text = ", α";
            // 
            // CalculadoraVectores3D
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(999, 787);
            ControlBox = false;
            Controls.Add(tbBZAlfaInput);
            Controls.Add(label35);
            Controls.Add(tbAZAlfaInput);
            Controls.Add(label34);
            Controls.Add(lblResultadoFinal);
            Controls.Add(lblResultadoZ);
            Controls.Add(lblResultadoSumaY);
            Controls.Add(lblResultadoA);
            Controls.Add(lblResultadoSumaX);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnBorrar);
            Controls.Add(btnCalcular);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblInstrucciones2);
            Controls.Add(lbl_instrucciones);
            Controls.Add(aRInput);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(aZInput);
            Controls.Add(bZInput);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(bRInput);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pblResultados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalculadoraVectores3D";
            Text = "CalculadoraVectores3D";
            pblResultados.ResumeLayout(false);
            pblResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResta;
        private Button btnSuma;
        private Label lblInstrucciones2;
        private Label lbl_instrucciones;
        private TextBox aRInput;
        private Label label3;
        private Label label9;
        private TextBox aZInput;
        private TextBox bZInput;
        private Label label4;
        private Label label8;
        private Label label5;
        private TextBox bRInput;
        private Label label2;
        private Label label7;
        private Label label6;
        private Button btnBorrar;
        private Button btnCalcular;
        private Label lblResultadoFinal;
        private Label lblResultadoZ;
        private Label lblResultadoSumaY;
        private Label lblResultadoA;
        private Label lblResultadoSumaX;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label14;
        private Label label13;
        private Label label12;
        private Panel pblResultados;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label18;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label lblResultadoBY;
        private Label lblResultadoBX;
        private Label lblValoresUsadosB;
        private Label lblResultadoAY;
        private Label lblResultadoAX;
        private Label lblValoresUsadosA;
        private Label label34;
        private TextBox tbAZAlfaInput;
        private TextBox tbBZAlfaInput;
        private Label label35;
        private Label lblVectorR;
        private Label lblRθ;
        private Label lblRY;
        private Label lblRMagnitud;
        private Label label28;
        private Label label29;
        private Label lblRX;
        private Label lblResultadoAz;
        private Label lblResultadoBZ;
        private Label lblResultadoAlfa;
    }
}