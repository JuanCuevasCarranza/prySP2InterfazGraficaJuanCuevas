namespace prySP2InterfazGraficaJuanCuevas
{
    partial class FrmReservaDeCabañas
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
            gbxTipoDeCabaña = new GroupBox();
            cmbDías = new ComboBox();
            cmbTipo2 = new ComboBox();
            lblDías = new Label();
            cmbPersonas2 = new ComboBox();
            lblPersonas = new Label();
            lblTipo = new Label();
            gbxAdicionales = new GroupBox();
            chkTELEVISOR = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            gbxFormasDePago = new GroupBox();
            cmbTarjetas2 = new ComboBox();
            lblTarjetas = new Label();
            rdEfectivo = new RadioButton();
            rdTarjeta = new RadioButton();
            gbxTitularDeReserva = new GroupBox();
            txtTelefonos2 = new TextBox();
            txtNombres2 = new TextBox();
            lblTelefonos = new Label();
            lblNombre = new Label();
            btnAceptar = new Button();
            gbxTipoDeCabaña.SuspendLayout();
            gbxAdicionales.SuspendLayout();
            gbxFormasDePago.SuspendLayout();
            gbxTitularDeReserva.SuspendLayout();
            SuspendLayout();
            // 
            // gbxTipoDeCabaña
            // 
            gbxTipoDeCabaña.Controls.Add(cmbDías);
            gbxTipoDeCabaña.Controls.Add(cmbTipo2);
            gbxTipoDeCabaña.Controls.Add(lblDías);
            gbxTipoDeCabaña.Controls.Add(cmbPersonas2);
            gbxTipoDeCabaña.Controls.Add(lblPersonas);
            gbxTipoDeCabaña.Controls.Add(lblTipo);
            gbxTipoDeCabaña.Location = new Point(28, 17);
            gbxTipoDeCabaña.Name = "gbxTipoDeCabaña";
            gbxTipoDeCabaña.Size = new Size(544, 100);
            gbxTipoDeCabaña.TabIndex = 0;
            gbxTipoDeCabaña.TabStop = false;
            gbxTipoDeCabaña.Text = "Tipo de cabaña";
            // 
            // cmbDías
            // 
            cmbDías.FormattingEnabled = true;
            cmbDías.Location = new Point(420, 41);
            cmbDías.Name = "cmbDías";
            cmbDías.Size = new Size(121, 23);
            cmbDías.TabIndex = 4;
            cmbDías.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbTipo2
            // 
            cmbTipo2.FormattingEnabled = true;
            cmbTipo2.Location = new Point(56, 44);
            cmbTipo2.Name = "cmbTipo2";
            cmbTipo2.Size = new Size(121, 23);
            cmbTipo2.TabIndex = 3;
            // 
            // lblDías
            // 
            lblDías.AutoSize = true;
            lblDías.Location = new Point(385, 49);
            lblDías.Name = "lblDías";
            lblDías.Size = new Size(29, 15);
            lblDías.TabIndex = 2;
            lblDías.Text = "Días";
            lblDías.Click += label3_Click;
            // 
            // cmbPersonas2
            // 
            cmbPersonas2.FormattingEnabled = true;
            cmbPersonas2.Location = new Point(249, 41);
            cmbPersonas2.Name = "cmbPersonas2";
            cmbPersonas2.Size = new Size(121, 23);
            cmbPersonas2.TabIndex = 0;
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(189, 49);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 1;
            lblPersonas.Text = "Personas";
            lblPersonas.Click += lblPersonas_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(19, 44);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // gbxAdicionales
            // 
            gbxAdicionales.Controls.Add(chkTELEVISOR);
            gbxAdicionales.Controls.Add(chkHeladera);
            gbxAdicionales.Controls.Add(chkCocina);
            gbxAdicionales.Location = new Point(28, 143);
            gbxAdicionales.Name = "gbxAdicionales";
            gbxAdicionales.Size = new Size(142, 135);
            gbxAdicionales.TabIndex = 1;
            gbxAdicionales.TabStop = false;
            gbxAdicionales.Text = "Adicionales";
            gbxAdicionales.Enter += groupBox1_Enter;
            // 
            // chkTELEVISOR
            // 
            chkTELEVISOR.AutoSize = true;
            chkTELEVISOR.Location = new Point(19, 105);
            chkTELEVISOR.Name = "chkTELEVISOR";
            chkTELEVISOR.Size = new Size(72, 19);
            chkTELEVISOR.TabIndex = 2;
            chkTELEVISOR.Text = "Televisor";
            chkTELEVISOR.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(19, 69);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(19, 34);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // gbxFormasDePago
            // 
            gbxFormasDePago.Controls.Add(cmbTarjetas2);
            gbxFormasDePago.Controls.Add(lblTarjetas);
            gbxFormasDePago.Controls.Add(rdEfectivo);
            gbxFormasDePago.Controls.Add(rdTarjeta);
            gbxFormasDePago.Location = new Point(187, 143);
            gbxFormasDePago.Name = "gbxFormasDePago";
            gbxFormasDePago.Size = new Size(385, 135);
            gbxFormasDePago.TabIndex = 2;
            gbxFormasDePago.TabStop = false;
            gbxFormasDePago.Text = "Formas de pago";
            // 
            // cmbTarjetas2
            // 
            cmbTarjetas2.FormattingEnabled = true;
            cmbTarjetas2.Location = new Point(169, 68);
            cmbTarjetas2.Name = "cmbTarjetas2";
            cmbTarjetas2.Size = new Size(172, 23);
            cmbTarjetas2.TabIndex = 5;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(179, 38);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(47, 15);
            lblTarjetas.TabIndex = 4;
            lblTarjetas.Text = "Tarjetas";
            lblTarjetas.Click += label3_Click_1;
            // 
            // rdEfectivo
            // 
            rdEfectivo.AutoSize = true;
            rdEfectivo.Location = new Point(24, 33);
            rdEfectivo.Name = "rdEfectivo";
            rdEfectivo.Size = new Size(67, 19);
            rdEfectivo.TabIndex = 3;
            rdEfectivo.TabStop = true;
            rdEfectivo.Text = "Efectivo";
            rdEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdTarjeta
            // 
            rdTarjeta.AutoSize = true;
            rdTarjeta.Location = new Point(24, 68);
            rdTarjeta.Name = "rdTarjeta";
            rdTarjeta.Size = new Size(60, 19);
            rdTarjeta.TabIndex = 0;
            rdTarjeta.TabStop = true;
            rdTarjeta.Text = "Tarjeta";
            rdTarjeta.UseVisualStyleBackColor = true;
            // 
            // gbxTitularDeReserva
            // 
            gbxTitularDeReserva.Controls.Add(txtTelefonos2);
            gbxTitularDeReserva.Controls.Add(txtNombres2);
            gbxTitularDeReserva.Controls.Add(lblTelefonos);
            gbxTitularDeReserva.Controls.Add(lblNombre);
            gbxTitularDeReserva.Location = new Point(28, 296);
            gbxTitularDeReserva.Name = "gbxTitularDeReserva";
            gbxTitularDeReserva.Size = new Size(544, 100);
            gbxTitularDeReserva.TabIndex = 3;
            gbxTitularDeReserva.TabStop = false;
            gbxTitularDeReserva.Text = "Titular de reserva";
            gbxTitularDeReserva.Enter += groupBox3_Enter;
            // 
            // txtTelefonos2
            // 
            txtTelefonos2.Location = new Point(101, 66);
            txtTelefonos2.Name = "txtTelefonos2";
            txtTelefonos2.Size = new Size(418, 23);
            txtTelefonos2.TabIndex = 8;
            // 
            // txtNombres2
            // 
            txtNombres2.Location = new Point(101, 31);
            txtNombres2.Name = "txtNombres2";
            txtNombres2.Size = new Size(418, 23);
            txtNombres2.TabIndex = 7;
            // 
            // lblTelefonos
            // 
            lblTelefonos.AutoSize = true;
            lblTelefonos.Location = new Point(19, 69);
            lblTelefonos.Name = "lblTelefonos";
            lblTelefonos.Size = new Size(58, 15);
            lblTelefonos.TabIndex = 6;
            lblTelefonos.Text = "Telefonos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(448, 423);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(109, 51);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FrmReservaDeCabañas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 503);
            Controls.Add(btnAceptar);
            Controls.Add(gbxTitularDeReserva);
            Controls.Add(gbxFormasDePago);
            Controls.Add(gbxAdicionales);
            Controls.Add(gbxTipoDeCabaña);
            Name = "FrmReservaDeCabañas";
            Text = "Reservas De Cabañas";
            gbxTipoDeCabaña.ResumeLayout(false);
            gbxTipoDeCabaña.PerformLayout();
            gbxAdicionales.ResumeLayout(false);
            gbxAdicionales.PerformLayout();
            gbxFormasDePago.ResumeLayout(false);
            gbxFormasDePago.PerformLayout();
            gbxTitularDeReserva.ResumeLayout(false);
            gbxTitularDeReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxTipoDeCabaña;
        private Label lblDías;
        private Label lblPersonas;
        private Label lblTipo;
        private GroupBox gbxAdicionales;
        private GroupBox gbxFormasDePago;
        private GroupBox gbxTitularDeReserva;
        private CheckBox chkTELEVISOR;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private RadioButton rdEfectivo;
        private RadioButton rdTarjeta;
        private ComboBox cmbTipo2;
        private ComboBox cmbDías;
        private Label lblTelefonos;
        private Label lblNombre;
        private ComboBox cmbPersonas2;
        private ComboBox cmbTarjetas2;
        private Label lblTarjetas;
        private TextBox txtTelefonos2;
        private TextBox txtNombres2;
        private Button btnAceptar;
    }
}
