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


        }





    }
}
