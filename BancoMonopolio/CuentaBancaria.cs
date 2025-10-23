using System.Text;

namespace BancoMonopolio
{
    public class CuentaBancaria
    {
        protected String numeroCuenta;
        protected String titular;
        protected double saldo;

        public CuentaBancaria(string numeroCuenta, string titular, double saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre titular: {this.titular}\n");
            sb.Append($"Numero de cuenta: {this.numeroCuenta}\n");
            sb.Append($"Saldo: {this.saldo}\n");
            return sb.ToString();
        }

        public string Depositar (double monto)
        {
            string mensajeSalida;
            if (monto <= 0)
            {
                mensajeSalida = "El monto tiene que ser positivo";
            }
            else
            {
                this.saldo += monto;
                mensajeSalida = $"Deposito de ${monto} realizado. Saldo actual: ${this.saldo}";
            }
            return mensajeSalida;


        }

        public string Retirar (double monto)
        {
            string mensajeSalida;

            if (monto <= 0)
            {
                mensajeSalida = "El monto tiene que ser positivo";
            }
            else
            {
                if (monto > this.saldo)
                {
                    mensajeSalida = "Saldo insuficiente.";
                }
                else
                {
                    this.saldo -= monto;
                    mensajeSalida = $"Extracción de ${monto} exitosa. Saldo actual ${this.saldo}";
                }
            }
            return mensajeSalida;
        }
    }
}
