namespace Hotel
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblHuesped = new Label();
            txtHuesped = new TextBox();
            lblNoches = new Label();
            nudNoches = new NumericUpDown();
            lblTarifa = new Label();
            txtTarifa = new TextBox();
            ckTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
            gbTotales = new GroupBox();
            lblTotal = new Label();
            lblServicio = new Label();
            lblITBIS = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNivel1 = new Button();
            lstResultados = new ListBox();
            nudTasa = new NumericUpDown();
            nudPersonas = new NumericUpDown();
            chkFinSemana = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            nudTarifa = new NumericUpDown();
            label9 = new Label();
            btnPesos = new Button();
            btnPorPersona = new Button();
            btnDeposito = new Button();
            btnFinSemana = new Button();
            btnDesglose = new Button();
            btnTraslado = new Button();
            btnExcursion = new Button();
            btnMinibar = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnCuentaTotal = new Button();
            label13 = new Label();
            btnViejo = new Button();
            btnFactura = new Button();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 187);
            label1.Name = "label1";
            label1.Size = new Size(0, 50);
            label1.TabIndex = 0;
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(22, 19);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(57, 15);
            lblHuesped.TabIndex = 2;
            lblHuesped.Text = "Huesped:";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(157, 11);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.PlaceholderText = "Ponga su nombre completo";
            txtHuesped.Size = new Size(252, 23);
            txtHuesped.TabIndex = 3;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(22, 59);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(50, 15);
            lblNoches.TabIndex = 4;
            lblNoches.Text = "Noches:";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(159, 58);
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(137, 23);
            nudNoches.TabIndex = 5;
            nudNoches.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(22, 109);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(126, 15);
            lblTarifa.TabIndex = 6;
            lblTarifa.Text = "Tarifa por noche (USD)";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(159, 106);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(100, 23);
            txtTarifa.TabIndex = 7;
            txtTarifa.TextChanged += textBox1_TextChanged;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Location = new Point(31, 161);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(149, 19);
            ckTemporada.TabIndex = 8;
            ckTemporada.Text = "Temporada alta (+25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(100, 399);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(12, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(label1);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(ckTemporada);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(txtTarifa);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Location = new Point(12, 36);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(415, 218);
            gbCotizador.TabIndex = 11;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblITBIS);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Controls.Add(label6);
            gbTotales.Controls.Add(label5);
            gbTotales.Controls.Add(label4);
            gbTotales.Controls.Add(label3);
            gbTotales.Controls.Add(label2);
            gbTotales.Location = new Point(12, 261);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(192, 132);
            gbTotales.TabIndex = 12;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(81, 113);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(15, 17);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(79, 91);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(13, 15);
            lblServicio.TabIndex = 8;
            lblServicio.Text = "0";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(79, 71);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(13, 15);
            lblITBIS.TabIndex = 7;
            lblITBIS.Text = "0";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(77, 47);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(13, 15);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "0";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(76, 25);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(13, 15);
            lblSubtotal.TabIndex = 5;
            lblSubtotal.Text = "0";
            lblSubtotal.Click += label11_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 113);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 4;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 91);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 3;
            label5.Text = "Servicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 71);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 2;
            label4.Text = "ITBIS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Descuento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 25);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Subtotal";
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(616, 36);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(99, 23);
            btnNivel1.TabIndex = 13;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(534, 323);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(271, 304);
            lstResultados.TabIndex = 14;
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(100, 480);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(120, 23);
            nudTasa.TabIndex = 15;
            nudTasa.Value = new decimal(new int[] { 61, 0, 0, 0 });
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(100, 523);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(120, 23);
            nudPersonas.TabIndex = 16;
            nudPersonas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(93, 608);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(143, 19);
            chkFinSemana.TabIndex = 17;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 482);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 18;
            label7.Text = "Tasa del dólar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 531);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 19;
            label8.Text = "Personas:";
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(100, 566);
            nudTarifa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(120, 23);
            nudTarifa.TabIndex = 20;
            nudTarifa.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 574);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 21;
            label9.Text = "Tarifa:";
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(488, 95);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(99, 23);
            btnPesos.TabIndex = 22;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(616, 95);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(99, 23);
            btnPorPersona.TabIndex = 23;
            btnPorPersona.Text = "Por Persona";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(738, 95);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(99, 23);
            btnDeposito.TabIndex = 24;
            btnDeposito.Text = "Depósito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(488, 124);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(98, 23);
            btnFinSemana.TabIndex = 25;
            btnFinSemana.Text = "Fin de Semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(739, 124);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(98, 23);
            btnDesglose.TabIndex = 26;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnTraslado
            // 
            btnTraslado.Location = new Point(489, 177);
            btnTraslado.Name = "btnTraslado";
            btnTraslado.Size = new Size(98, 23);
            btnTraslado.TabIndex = 27;
            btnTraslado.Text = "Traslado";
            btnTraslado.UseVisualStyleBackColor = true;
            btnTraslado.Click += btnTraslado_Click;
            // 
            // btnExcursion
            // 
            btnExcursion.Location = new Point(616, 177);
            btnExcursion.Name = "btnExcursion";
            btnExcursion.Size = new Size(99, 23);
            btnExcursion.TabIndex = 28;
            btnExcursion.Text = "Excursion";
            btnExcursion.UseVisualStyleBackColor = true;
            btnExcursion.Click += btnExcursion_Click;
            // 
            // btnMinibar
            // 
            btnMinibar.Location = new Point(739, 177);
            btnMinibar.Name = "btnMinibar";
            btnMinibar.Size = new Size(98, 23);
            btnMinibar.TabIndex = 29;
            btnMinibar.Text = "Minibar";
            btnMinibar.UseVisualStyleBackColor = true;
            btnMinibar.Click += btnMinibar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(568, 9);
            label10.Name = "label10";
            label10.Size = new Size(196, 15);
            label10.TabIndex = 30;
            label10.Text = "PRIMEROS 10 EJERCICIOS NIVEL 1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(616, 77);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 31;
            label11.Text = "EJERCICIOS NIVEL 2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(616, 145);
            label12.Name = "label12";
            label12.Size = new Size(116, 15);
            label12.TabIndex = 32;
            label12.Text = "EJERCICIOS NIVEL 3";
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(616, 206);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(99, 23);
            btnCuentaTotal.TabIndex = 33;
            btnCuentaTotal.Text = "Cuenta total";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(613, 239);
            label13.Name = "label13";
            label13.Size = new Size(119, 15);
            label13.TabIndex = 34;
            label13.Text = "EJERCICIOS NIVEL 4 ";
            // 
            // btnViejo
            // 
            btnViejo.Location = new Point(593, 261);
            btnViejo.Name = "btnViejo";
            btnViejo.Size = new Size(139, 23);
            btnViejo.TabIndex = 35;
            btnViejo.Text = "Probar sistema viejo";
            btnViejo.UseVisualStyleBackColor = true;
            btnViejo.Click += btnViejo_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(394, 374);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(75, 23);
            btnFactura.TabIndex = 36;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(348, 352);
            label14.Name = "label14";
            label14.Size = new Size(167, 15);
            label14.TabIndex = 37;
            label14.Text = "RETO FINAL FACTURA TOTAL";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 639);
            Controls.Add(label14);
            Controls.Add(btnFactura);
            Controls.Add(btnViejo);
            Controls.Add(label13);
            Controls.Add(btnCuentaTotal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnMinibar);
            Controls.Add(btnExcursion);
            Controls.Add(btnTraslado);
            Controls.Add(btnDesglose);
            Controls.Add(btnFinSemana);
            Controls.Add(btnDeposito);
            Controls.Add(btnPorPersona);
            Controls.Add(btnPesos);
            Controls.Add(label9);
            Controls.Add(nudTarifa);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(chkFinSemana);
            Controls.Add(nudPersonas);
            Controls.Add(nudTasa);
            Controls.Add(lstResultados);
            Controls.Add(btnNivel1);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral - Ismanol 2024-3437";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblHuesped;
        private TextBox txtHuesped;
        private Label lblNoches;
        private NumericUpDown nudNoches;
        private Label lblTarifa;
        private TextBox txtTarifa;
        private CheckBox ckTemporada;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gbCotizador;
        private GroupBox gbTotales;
        private Label lblTotal;
        private Label lblServicio;
        private Label lblITBIS;
        private Label lblDescuento;
        private Label lblSubtotal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnNivel1;
        private ListBox lstResultados;
        private NumericUpDown nudTasa;
        private NumericUpDown nudPersonas;
        private CheckBox chkFinSemana;
        private Label label7;
        private Label label8;
        private NumericUpDown nudTarifa;
        private Label label9;
        private Button btnPesos;
        private Button btnPorPersona;
        private Button btnDeposito;
        private Button btnFinSemana;
        private Button btnDesglose;
        private Button btnTraslado;
        private Button btnExcursion;
        private Button btnMinibar;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCuentaTotal;
        private Label label13;
        private Button btnViejo;
        private Button btnFactura;
        private Label label14;
    }
}
