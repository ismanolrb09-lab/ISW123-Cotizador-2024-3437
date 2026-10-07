namespace Hotel
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            // 1.1
            int a = 10;
            int b = 3;
            int r11 = a / b;

            //Mostrar los resultados en el list
            lstResultados.Items.Clear();
            lstResultados.Items.Add($"1.1: {r11}");

            // 1.2
            decimal r12 = 10 / 4m;
            lstResultados.Items.Add($"1.2: {r12}");

            // 1.3
            int x = 5;
            x = x + 2;
            x = x * 3;

            lstResultados.Items.Add($"1.3: {x}");

            // 1.4
            decimal p = 200m;
            decimal r14 = p * 0.18m;

            lstResultados.Items.Add($"1.4: {r14}");

            // 1.5
            int n15 = 7;
            decimal d = 0m;
            if (n15 > 7)
            {
                d = 50m;
            }
            lstResultados.Items.Add($"1.5: {d}");

            // 1.6
            int n16 = 7;
            bool larga = n16 >= 7;

            lstResultados.Items.Add($"1.6: {larga}");

            // 1.7
            string s = "Villa" + "Coral";
            lstResultados.Items.Add($"1.7: {s}");

            // 1.8
            int n18 = 4;
            decimal t18 = 100m;
            decimal total = n18 * t18 * 1.28m;
            lstResultados.Items.Add($"1.8: {total}");

            // 1.9
            decimal t19 = 120m;
            t19 = t19 + t19 * 0.25m;

            lstResultados.Items.Add($"1.9: {t19}");

            // 1.10
            int noches = (int)8.9m;

            lstResultados.Items.Add($"1.10: {noches}");

        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };
            lstResultados.Items.Add($"Total en RD$: {reserva.Total * nudTasa.Value:N2}");
        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };
            lstResultados.Items.Add($"Por Persona: US$ {reserva.Total / nudPersonas.Value:N2}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };
            decimal deposito = reserva.Total * 0.30m;
            lstResultados.Items.Add($"Depósito: US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo pendiente: US$ {reserva.Total - deposito:N2}");
        }
    }
}