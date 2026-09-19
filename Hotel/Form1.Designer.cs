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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTotal = new Label();
            lblServicio = new Label();
            lblITBIS = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
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
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            ckTemporada.Size = new Size(145, 19);
            ckTemporada.TabIndex = 8;
            ckTemporada.Text = "Temoirada alta (+25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(285, 366);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(285, 432);
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
            gbTotales.Location = new Point(14, 323);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(192, 132);
            gbTotales.TabIndex = 12;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Descuento";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 91);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 3;
            label5.Text = "Servicio";
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
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
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
            ResumeLayout(false);
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
    }
}
