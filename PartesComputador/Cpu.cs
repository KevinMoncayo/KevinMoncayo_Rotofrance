using System.Numerics;
using System.Text;

namespace PartesComputador
{
    public class Cpu
    {
        /* Atributos
        * Constructor
        * Propiedades
        * Getters y Setters
        * El resto de los métodos
        * 
        * Nombre, medio de comunicación, legajo y nota.
        * Visibilidad - Tipado - nombre (lowerCamelCase y sustantivo, singular salvo qeu sean colecciones)
        */

        /*Gabinete CPU
         * Placa base
         * Procesador
         * Memoria RAM
         * Fuente de alimentación -> int -> W
         * Disco duro/ SSD -> int -> GB
         * Tarjeta gráfica(si no esta integrada) -> int -> GB
         * Sistema de refrigeración -> string
         * Gabinete
         */

        private string motherBoard;
        private int ram; //Cantidad de memoria en Gb.
        private string procesador;
        private string placaAudio;
        private string placaRed;
        //private string sistemaRefrigeracion; //Va a desaparecer por propiedad autoreferenciada

        //Atributo estatico
        private static string gabinete;// Clase -> Estatico
        private static int cantidadCpuArmadas;

        //Creo un constructor estatico para inicializar los parámetros estaticos la primera vez que entro a la clase
        static Cpu()
        {
            gabinete = "Alienware";
            cantidadCpuArmadas = 0;
        }

        public Cpu()
        {
            cantidadCpuArmadas++;
        }

        //Al implementar el :this() estoy implementando una forma de llamar al constructor sin parámetros para que haga un incremento a la variable CantidadCpuArmadas
        public Cpu(string motherBoard, int ram, string procesador, string placaAudio, string placaRed) : this()
        {
            this.motherBoard = motherBoard;
            this.ram = ram;
            this.procesador = procesador;
            this.placaAudio = placaAudio;
            this.placaRed = placaRed;
        }

        #region Properties
        //Creación de propiedad Motherboard, la reglas es que se llame igual que el atributo y que empiece con Mayúscula.
        public string MotherBoard
        {
            get {
                return this.motherBoard;
            }
            set {
                if (value != string.Empty)
                {
                    this.motherBoard = value;
                }
                
            }
        }

        //Si una propiedad solamente tiene GET, seria una propiedad solo de lectura.
        //Las propiedades no reciben parámetros...

        public int Ram
        {
            get {
                return this.ram;
            }
            set
            {
                if (value > 4 && value < 256)
                {
                    this.ram = value;
                }
            }
        }

        public string Procesador
        {
            get
            {
                return this.procesador;
            }
            set
            {
                this.procesador = value;
            }
        }

        public string PlacaAudio
        {
            get
            {
                return this.placaAudio;
            }
            set
            {
                this.placaAudio = value;
            }
        }

        public string PlacaRed
        {
            get
            {
                return this.placaRed;
            }
            set
            {
                this.placaRed = value;
            }
        }

        public int Benchmark
        {
            get
            {
                return this.HacerBenchmark();
            }
        }

        /*Ejemplo de propiedad "autorreferenciada"
         * No esta referida a ningún atributo.
         * Puede tener un get y/o set sin implementar.
         * El dato no se almacena en ningún atributo, sino directamente en una propiedad...
         */
        public string SistemaRefrigeracion
        {
            get;
            set;
        }
        #endregion

        //Metodo mostrar cpu

        public string MostrarCpu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Placa base: " + this.motherBoard);
            sb.AppendLine("RAM: " + this.ram + " GB");
            sb.AppendLine("Procesador: " + this.procesador);
            sb.AppendLine("Placa de audio: " + this.placaAudio);
            sb.AppendLine("Placa de red: " + this.placaRed);
            sb.AppendLine("Gabinete: " + gabinete);
            sb.AppendLine("Cantidad de CPU creadas: " + cantidadCpuArmadas);
            return sb.ToString();
        }

        private int HacerBenchmark()
        {
            int limite = 100;
            int benchmark;
            Random numeroAleatorio = new Random();
            benchmark = numeroAleatorio.Next(limite);
            return benchmark;
        }
        /*
        public bool CrearProcesos(int numeroProcesos)
        {
            bool exito = false;
            int procesosActivos;
            procesosActivos += numeroProcesos;
            return exito;
        }
        */

        //Añadir tres metodos que hagan algo... que tengan lógica...
        //Como y donde instancio una clase?

        //Debido a las caracteristicas propias de las comparaciones de objetos, para comparar una Cpu con otra lo mejor es crear un método para ello.
        public static bool CompararEstatico(Cpu cpu1, Cpu cpu2)
        {
            //bool comparacion = false;

            //if(cpu1.MotherBoard == cpu2.MotherBoard && cpu1.Procesador == cpu2.Procesador && cpu1.Ram == cpu2.Ram && cpu1.PlacaAudio == cpu2.PlacaAudio && cpu1.PlacaRed == cpu2.PlacaRed)
            //{ 
            //    comparacion = true;
            //}

            //return comparacion;
            return cpu1.CompararCpu(cpu2);
        }

        public bool CompararCpu(Cpu cpuComparar)
        {
            bool comparacion = false;

            if (this.MotherBoard == cpuComparar.MotherBoard && this.Procesador == cpuComparar.Procesador && this.Ram == cpuComparar.Ram && this.PlacaAudio == cpuComparar.PlacaAudio && this.PlacaRed == cpuComparar.PlacaRed)
            {
                comparacion = true;
            }

            return comparacion;
            //return CompararEstatico(this, cpuComparar);
        }

    }
}
