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

    }
}
