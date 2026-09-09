namespace prySP2InterfazGraficaJuanCuevas
{
    public partial class FrmReservaDeCabañas : Form
    {
        public FrmReservaDeCabañas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void gbxFormasDePago_Enter(object sender, EventArgs e)
        {

        }

        private void gbxTipoDeCabaña_Enter(object sender, EventArgs e)
        {

        }

        private void rdEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEfectivo.Checked == true)
            {
                cmbTarjetas2.Enabled = false;
                cmbTarjetas2.SelectedIndex = -1; // Desselecciona la tarjeta
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int varDias = int.Parse(txtDías.Text);

            switch (varDias)
            {
                case 1:
                    lblResultado.Text = "descuento 1%";
                    break;
                case < 5:
                    lblResultado.Text = "descuento 5%";
                    break;
                case < 7:
                    lblResultado.Text = "descuento 7%";
                    break;
                case >= 7:
                    lblResultado.Text = "descuento 10%";
                    break;
                default:
                    lblResultado.Text = "sin descuento";
                    break;
            }

            string varAdicionales = "";

            if (chkCocina.Checked == true) 
            {
                varAdicionales += "Cocina ";
            }

            if (chkHeladera.Checked == true)
            {
                varAdicionales += "Heladera ";
            }

            if (chkTelevisor.Checked == true)
            {
                varAdicionales += "Televisor";
            }

            lblResultado.Text = varAdicionales;


        }

        private void rdTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTarjeta.Checked == true)
            {
                cmbTarjetas2.Enabled = true;

                if (cmbTarjetas2.Items.Count > 0)
                {
                    cmbTarjetas2.SelectedIndex = 0;
                }
            }
        }

        private void cmbTarjetas2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTarjetas2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
