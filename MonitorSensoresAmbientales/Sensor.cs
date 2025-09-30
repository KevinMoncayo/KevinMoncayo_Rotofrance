using System.Text;

namespace MonitorSensoresAmbientales
{
    public class Sensor
    {
        #region Atributos

        private string nombre;
        private string unidad;
        private double valorActual;

        private static int cantidadSensores;

        #endregion

        #region Constructores

        static Sensor()
        {
            cantidadSensores = 0;
        }

        public Sensor()
        {
            cantidadSensores++;
        }

        public Sensor(string nombre, string unidad) : this()
        {
            this.nombre = nombre;
            this.unidad = unidad;
        }

        #endregion

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.nombre = value;
                }
            }
        }

        public string Unidad { 
            get
            {
                return this.unidad;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.unidad = value;
                }
            }
        }

        public double ValorActual
        {
            get
            {
                return this.valorActual;
            }
        }

        public double LeerValorTTL
        {
            get
            {
                this.valorActual = LeerSensor("TTL");
                return this.valorActual;
            }
        }

        public double LeerValorCMOS
        {
            get
            {
                this.valorActual = LeerSensor("CMOS");
                return this.ValorActual;
            }
        }

        public string CategoriaSensor
        {
            get
            {
                return CategoriaSensor;
            }
            set
            {
                if (value != string.Empty)
                {
                    CategoriaSensor = value;
                }
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra la información técnica del sensor
        /// </summary>
        /// <returns>Una cadena con él nombre del sensor, la unidad que mide y el valor actual.</returns>
        public string Datasheet()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El nombre de este sensor es: {this.nombre}");
            sb.AppendLine($"La unidad que mide este sensor es: {this.nombre}");
            sb.AppendLine($"El valor actual de este sensor es: {this.valorActual} {this.unidad}");
            return sb.ToString();
        }

        /// <summary>
        /// Esta función retorna un valor aleatorio entre 0 y un límite superior. El límite superior esta definido por el parametro nivelLogicoSalida.
        /// </summary>
        /// <param name="nivelLogicoSalida">Ingrese una cadena con TTL para un nivel lógico de salida entre 0 y 5 V. En su defecto la salida tendrá nivel de salida CMOS, definida entre 0 y 3.3 V</param>
        /// <returns>Valor ficticio de lectura del sensor definido de acuerdo al tipo de lógica necesaria, ya sea TTL o CMOS.</returns>
        private double LeerSensor(string nivelLogicoSalida)
        { 
            //Este método deberia leer de forma serial a través de un puerto COM el dato que el uC le envíe
            Random numeroAleatorio = new Random();
            double valorLeido,valorTTL,valorCMOS,salida;
            valorLeido = numeroAleatorio.NextDouble();
            
            
            if (nivelLogicoSalida == "TTL")
            {
                valorTTL = valorLeido * 5;
                salida = valorTTL;
            }
            else
            {
                valorCMOS = valorLeido * 3.3;
                salida = valorCMOS;
            }
            return salida;
        }
        /// <summary>
        /// Verifica si el valor actual está dentro de un rango aceptable definido por el sensor.
        /// </summary>
        /// <param name="limiteInferior">Limite inferior del sensor.</param>
        /// <param name="limiteSuperior">Limite superior del sensor.</param>
        /// <returns>Retorna un valor booleano True si la lectura del sensor se encuentra dentro de los limites definidos. Caso contrario retorna False.</returns>
        public bool ValidarLecturaSensor(double limiteInferior, double limiteSuperior)
        {
            bool validar = false;

            if (this.valorActual >= limiteInferior && this.valorActual <= limiteSuperior)
            {
                validar = true;
            }

            return validar;
        }



        #endregion
    }
}
