namespace Calculadora
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            string valorNumero1 = this.txtPrimerOperando.Text;
            string valorNumero2 = this.txtSegundoOperando.Text;

            double suma = int.Parse(valorNumero1) + int.Parse(valorNumero2);

            this.lblResultado.Text = suma.ToString();
        }

        private void btnRestar_Click(object render, EventArgs e)
        {
            string valorNumero1 = this.txtPrimerOperando.Text;
            string valorNumero2 = this.txtSegundoOperando.Text;

            double resta = int.Parse(valorNumero1) - int.Parse(valorNumero2);

            this.lblResultado.Text = resta.ToString();
        }

        private void btnMultiplocar_Click(object sender, EventArgs e)
        {
            string valorNumero1 = this.txtPrimerOperando.Text;
            string valorNumero2 = this.txtSegundoOperando.Text;

            double multiplicacion = int.Parse(valorNumero1) * int.Parse(valorNumero2);

            this.lblResultado.Text = multiplicacion.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string valorNumero1 = this.txtPrimerOperando.Text;
            string valorNumero2 = this.txtSegundoOperando.Text;

            if (int.Parse(valorNumero2) == 0)
            {
                this.lblResultado.Text = "Indeterminado - Division entre cero";
            }
            else
            {
                double dividir = int.Parse(valorNumero1) / int.Parse(valorNumero2);
                this.lblResultado.Text = dividir.ToString();
            }


            
        }
    }
}
