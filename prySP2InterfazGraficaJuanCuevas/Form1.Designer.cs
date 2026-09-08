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
            lblTipo = new Label();
            lblPersonas = new Label();
            lblDías = new Label();
            gbxAdicionales = new GroupBox();
            gbxFormasDePago = new GroupBox();
            gbxTitularDeReserva = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox4 = new ComboBox();
            btnAceptar = new Button();
            gbxTipoDeCabaña.SuspendLayout();
            gbxAdicionales.SuspendLayout();
            gbxFormasDePago.SuspendLayout();
            gbxTitularDeReserva.SuspendLayout();
            SuspendLayout();
            // 
            // gbxTipoDeCabaña
            // 
            gbxTipoDeCabaña.Controls.Add(comboBox2);
            gbxTipoDeCabaña.Controls.Add(comboBox1);
            gbxTipoDeCabaña.Controls.Add(lblDías);
            gbxTipoDeCabaña.Controls.Add(comboBox3);
            gbxTipoDeCabaña.Controls.Add(lblPersonas);
            gbxTipoDeCabaña.Controls.Add(lblTipo);
            gbxTipoDeCabaña.Location = new Point(28, 17);
            gbxTipoDeCabaña.Name = "gbxTipoDeCabaña";
            gbxTipoDeCabaña.Size = new Size(544, 100);
            gbxTipoDeCabaña.TabIndex = 0;
            gbxTipoDeCabaña.TabStop = false;
            gbxTipoDeCabaña.Text = "Tipo de cabaña";
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
            // gbxAdicionales
            // 
            gbxAdicionales.Controls.Add(checkBox4);
            gbxAdicionales.Controls.Add(checkBox3);
            gbxAdicionales.Controls.Add(checkBox2);
            gbxAdicionales.Location = new Point(28, 143);
            gbxAdicionales.Name = "gbxAdicionales";
            gbxAdicionales.Size = new Size(142, 135);
            gbxAdicionales.TabIndex = 1;
            gbxAdicionales.TabStop = false;
            gbxAdicionales.Text = "Adicionales";
            gbxAdicionales.Enter += groupBox1_Enter;
            // 
            // gbxFormasDePago
            // 
            gbxFormasDePago.Controls.Add(comboBox4);
            gbxFormasDePago.Controls.Add(label3);
            gbxFormasDePago.Controls.Add(radioButton1);
            gbxFormasDePago.Controls.Add(radioButton2);
            gbxFormasDePago.Location = new Point(187, 143);
            gbxFormasDePago.Name = "gbxFormasDePago";
            gbxFormasDePago.Size = new Size(385, 135);
            gbxFormasDePago.TabIndex = 2;
            gbxFormasDePago.TabStop = false;
            gbxFormasDePago.Text = "Formas de pago";
            // 
            // gbxTitularDeReserva
            // 
            gbxTitularDeReserva.Controls.Add(textBox2);
            gbxTitularDeReserva.Controls.Add(textBox1);
            gbxTitularDeReserva.Controls.Add(label2);
            gbxTitularDeReserva.Controls.Add(label1);
            gbxTitularDeReserva.Location = new Point(28, 296);
            gbxTitularDeReserva.Name = "gbxTitularDeReserva";
            gbxTitularDeReserva.Size = new Size(544, 100);
            gbxTitularDeReserva.TabIndex = 3;
            gbxTitularDeReserva.TabStop = false;
            gbxTitularDeReserva.Text = "Titular de reserva";
            gbxTitularDeReserva.Enter += groupBox3_Enter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Efectivo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(24, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(19, 34);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Cocina";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(19, 69);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(73, 19);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "Heladera";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(19, 105);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 19);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "Televisor";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(420, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(249, 41);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefonos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(418, 23);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 73);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Tarjetas";
            label3.Click += label3_Click_1;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(137, 103);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(172, 23);
            comboBox4.TabIndex = 5;
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
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnAceptar;
    }
}
