namespace Calculadoras
{
    partial class CalculadoraVectores2D
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
            btnCalcular = new Button();
            btnBorrar = new Button();
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
            lblInstrucciones2 = new Label();
            pblResultados = new Panel();
            lblResultadoFinal = new Label();
            lblResultadoZ = new Label();
            lblResultadoSumaY = new Label();
            lblResultadoA = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            lblResultadoSumaX = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            pblResultados.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top;
            btnCalcular.BackColor = Color.FromArgb(38, 38, 38);
            btnCalcular.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(416, 720);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(254, 51);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Top;
            btnBorrar.BackColor = Color.FromArgb(38, 38, 38);
            btnBorrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(143, 720);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(254, 51);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lbl_instrucciones
            // 
            lbl_instrucciones.Dock = DockStyle.Top;
            lbl_instrucciones.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_instrucciones.Location = new Point(0, 0);
            lbl_instrucciones.Name = "lbl_instrucciones";
            lbl_instrucciones.Size = new Size(798, 56);
            lbl_instrucciones.TabIndex = 32;
            lbl_instrucciones.Text = "Entre las coordenadas polares para los vectores A y B.\r\n";
            lbl_instrucciones.TextAlign = ContentAlignment.BottomCenter;
            // 
            // aRInput
            // 
            aRInput.Anchor = AnchorStyles.Top;
            aRInput.BackColor = SystemColors.ButtonFace;
            aRInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            aRInput.Location = new Point(139, 216);
            aRInput.Margin = new Padding(3, 4, 3, 4);
            aRInput.Name = "aRInput";
            aRInput.Size = new Size(65, 38);
            aRInput.TabIndex = 20;
            aRInput.TextAlign = HorizontalAlignment.Center;
            aRInput.WordWrap = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(211, 216);
            label3.Name = "label3";
            label3.Size = new Size(53, 40);
            label3.TabIndex = 21;
            label3.Text = ", θ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(699, 216);
            label9.Name = "label9";
            label9.Size = new Size(28, 40);
            label9.TabIndex = 31;
            label9.Text = ")";
            // 
            // aZInput
            // 
            aZInput.Anchor = AnchorStyles.Top;
            aZInput.BackColor = SystemColors.ButtonFace;
            aZInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            aZInput.Location = new Point(270, 216);
            aZInput.Margin = new Padding(3, 4, 3, 4);
            aZInput.Name = "aZInput";
            aZInput.Size = new Size(65, 38);
            aZInput.TabIndex = 22;
            aZInput.TextAlign = HorizontalAlignment.Center;
            aZInput.WordWrap = false;
            // 
            // bZInput
            // 
            bZInput.Anchor = AnchorStyles.Top;
            bZInput.BackColor = SystemColors.ButtonFace;
            bZInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bZInput.Location = new Point(627, 216);
            bZInput.Margin = new Padding(3, 4, 3, 4);
            bZInput.Name = "bZInput";
            bZInput.Size = new Size(65, 38);
            bZInput.TabIndex = 30;
            bZInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(342, 216);
            label4.Name = "label4";
            label4.Size = new Size(28, 40);
            label4.TabIndex = 23;
            label4.Text = ")";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Tomato;
            label8.Location = new Point(569, 216);
            label8.Name = "label8";
            label8.Size = new Size(53, 40);
            label8.TabIndex = 29;
            label8.Text = ", θ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(73, 185);
            label5.Name = "label5";
            label5.Size = new Size(40, 27);
            label5.TabIndex = 24;
            label5.Text = "⇀";
            // 
            // bRInput
            // 
            bRInput.Anchor = AnchorStyles.Top;
            bRInput.BackColor = SystemColors.ButtonFace;
            bRInput.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bRInput.Location = new Point(496, 216);
            bRInput.Margin = new Padding(3, 4, 3, 4);
            bRInput.Name = "bRInput";
            bRInput.Size = new Size(65, 38);
            bRInput.TabIndex = 28;
            bRInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(73, 216);
            label2.Name = "label2";
            label2.Size = new Size(63, 45);
            label2.TabIndex = 25;
            label2.Text = "A(r";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Tomato;
            label7.Location = new Point(427, 216);
            label7.Name = "label7";
            label7.Size = new Size(62, 43);
            label7.TabIndex = 27;
            label7.Text = "B(r";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(427, 185);
            label6.Name = "label6";
            label6.Size = new Size(40, 27);
            label6.TabIndex = 26;
            label6.Text = "⇀";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInstrucciones2
            // 
            lblInstrucciones2.Dock = DockStyle.Top;
            lblInstrucciones2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstrucciones2.ForeColor = Color.FromArgb(64, 64, 64);
            lblInstrucciones2.Location = new Point(0, 56);
            lblInstrucciones2.Name = "lblInstrucciones2";
            lblInstrucciones2.Size = new Size(798, 63);
            lblInstrucciones2.TabIndex = 63;
            lblInstrucciones2.Text = "R representa la magnitud.\r\nθ representa la dirección.";
            lblInstrucciones2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pblResultados
            // 
            pblResultados.Anchor = AnchorStyles.Top;
            pblResultados.BackColor = SystemColors.ButtonFace;
            pblResultados.BorderStyle = BorderStyle.FixedSingle;
            pblResultados.Controls.Add(lblResultadoFinal);
            pblResultados.Controls.Add(lblResultadoZ);
            pblResultados.Controls.Add(lblResultadoSumaY);
            pblResultados.Controls.Add(lblResultadoA);
            pblResultados.Controls.Add(label22);
            pblResultados.Controls.Add(label21);
            pblResultados.Controls.Add(label20);
            pblResultados.Controls.Add(label19);
            pblResultados.Controls.Add(lblResultadoSumaX);
            pblResultados.Controls.Add(label15);
            pblResultados.Controls.Add(label16);
            pblResultados.Controls.Add(label17);
            pblResultados.Controls.Add(label14);
            pblResultados.Controls.Add(label13);
            pblResultados.Controls.Add(label12);
            pblResultados.Location = new Point(14, 304);
            pblResultados.Margin = new Padding(3, 4, 3, 4);
            pblResultados.Name = "pblResultados";
            pblResultados.Size = new Size(770, 394);
            pblResultados.TabIndex = 64;
            // 
            // lblResultadoFinal
            // 
            lblResultadoFinal.Anchor = AnchorStyles.Top;
            lblResultadoFinal.AutoSize = true;
            lblResultadoFinal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoFinal.Location = new Point(554, 335);
            lblResultadoFinal.Name = "lblResultadoFinal";
            lblResultadoFinal.Size = new Size(0, 24);
            lblResultadoFinal.TabIndex = 77;
            // 
            // lblResultadoZ
            // 
            lblResultadoZ.Anchor = AnchorStyles.Top;
            lblResultadoZ.AutoSize = true;
            lblResultadoZ.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoZ.Location = new Point(554, 256);
            lblResultadoZ.Name = "lblResultadoZ";
            lblResultadoZ.Size = new Size(0, 23);
            lblResultadoZ.TabIndex = 76;
            // 
            // lblResultadoSumaY
            // 
            lblResultadoSumaY.Anchor = AnchorStyles.Top;
            lblResultadoSumaY.AutoSize = true;
            lblResultadoSumaY.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoSumaY.Location = new Point(554, 160);
            lblResultadoSumaY.Name = "lblResultadoSumaY";
            lblResultadoSumaY.Size = new Size(0, 23);
            lblResultadoSumaY.TabIndex = 75;
            // 
            // lblResultadoA
            // 
            lblResultadoA.Anchor = AnchorStyles.Top;
            lblResultadoA.AutoSize = true;
            lblResultadoA.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoA.Location = new Point(554, 220);
            lblResultadoA.Name = "lblResultadoA";
            lblResultadoA.Size = new Size(0, 23);
            lblResultadoA.TabIndex = 74;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(554, 65);
            label22.Name = "label22";
            label22.Size = new Size(129, 29);
            label22.TabIndex = 73;
            label22.Text = "Resultado";
            label22.Visible = false;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(546, 304);
            label21.Name = "label21";
            label21.Size = new Size(27, 29);
            label21.TabIndex = 72;
            label21.Text = "⇀";
            label21.Visible = false;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Tomato;
            label20.Location = new Point(266, 39);
            label20.Name = "label20";
            label20.Size = new Size(27, 29);
            label20.TabIndex = 71;
            label20.Text = "⇀";
            label20.Visible = false;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.CornflowerBlue;
            label19.Location = new Point(14, 39);
            label19.Name = "label19";
            label19.Size = new Size(27, 29);
            label19.TabIndex = 70;
            label19.Text = "⇀";
            label19.Visible = false;
            // 
            // lblResultadoSumaX
            // 
            lblResultadoSumaX.Anchor = AnchorStyles.Top;
            lblResultadoSumaX.AutoSize = true;
            lblResultadoSumaX.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultadoSumaX.Location = new Point(554, 124);
            lblResultadoSumaX.Name = "lblResultadoSumaX";
            lblResultadoSumaX.Size = new Size(0, 23);
            lblResultadoSumaX.TabIndex = 69;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(273, 160);
            label15.Name = "label15";
            label15.Size = new Size(0, 23);
            label15.TabIndex = 68;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(273, 124);
            label16.Name = "label16";
            label16.Size = new Size(0, 23);
            label16.TabIndex = 67;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Tomato;
            label17.Location = new Point(273, 65);
            label17.Name = "label17";
            label17.Size = new Size(0, 29);
            label17.TabIndex = 66;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(19, 160);
            label14.Name = "label14";
            label14.Size = new Size(0, 23);
            label14.TabIndex = 65;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(19, 124);
            label13.Name = "label13";
            label13.Size = new Size(0, 23);
            label13.TabIndex = 64;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.CornflowerBlue;
            label12.Location = new Point(19, 65);
            label12.Name = "label12";
            label12.Size = new Size(0, 29);
            label12.TabIndex = 63;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(376, 197);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(38, 29);
            btnSuma.TabIndex = 66;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(376, 245);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(38, 29);
            btnResta.TabIndex = 67;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // CalculadoraVectores2D
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(798, 787);
            ControlBox = false;
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(pblResultados);
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
            Controls.Add(btnBorrar);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalculadoraVectores2D";
            Text = "CalculadoraVectores2D";
            pblResultados.ResumeLayout(false);
            pblResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalcular;
        private Button btnBorrar;
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
        private Label lblInstrucciones2;
        private Panel pblResultados;
        private Label lblResultadoFinal;
        private Label lblResultadoZ;
        private Label lblResultadoSumaY;
        private Label lblResultadoA;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label lblResultadoSumaX;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button btnSuma;
        private Button btnResta;
    }
}