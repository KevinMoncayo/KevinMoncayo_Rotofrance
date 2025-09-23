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
         * Fuente de alimentación
         * Disco duro/ SSD
         * Tarjeta gráfica(si no esta integrada)
         * Sistema de refrigeración
         * Gabinete
         */

        private string MotherBoard;
        private int Ram; //Cantidad de memoria en Gb.
        private string Procesador;
        private string PlacaAudio;
        private string PlacaRed;

        //Atributo estatico
        private static string gabinete;// Clase -> Estatico
        public static int cantidadCpuArmadas;

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
        public Cpu(string motherBoard, int ram, string procesador, string placaAudio, string placaRed):this()
        {
            this.MotherBoard = motherBoard;
            this.Ram = ram;
            this.Procesador = procesador;
            this.PlacaAudio = placaAudio;
            this.PlacaRed = placaRed;
        }

        #region Getters
        public string GetMotherBoard()
        {
            return this.MotherBoard;
        }

        public int GetRam()
        {
            return this.Ram;
        }
        public string GetProcesador()
        {
            return this.Procesador;
        }

        public string GetPlacaAudio()
        {
            return this.PlacaAudio;
        }

        public string GetPlacaRed()
        {
            return this.PlacaRed;
        }
        #endregion

        #region Setters

        public void SetMotherBoard(string motherboard)
        {

            this.MotherBoard = motherboard;
        }

        public void SetRam(int ram)
        {
            this.Ram = ram;
        }

        public void SetProcesador(string procesador)
        {
            this.Procesador = procesador;
        }

        public void SetPlacaAudio(string placaAudio)
        {
            this.PlacaAudio = placaAudio;
        }

        public void SetPlacaRed(string placaRed)
        {
            this.PlacaRed = placaRed;
        }
        #endregion

        //Metodo mostrar cpu

        public string MostrarCpu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Placa base: "+ this.MotherBoard);
            sb.AppendLine("RAM: "+this.Ram+" GB");
            sb.AppendLine("Procesador: " + this.Procesador);
            sb.AppendLine("Placa de audio: "+this.PlacaAudio);
            sb.AppendLine("Placa de red: " + this.PlacaRed);
            sb.AppendLine("Gabinete: " + gabinete);
            sb.AppendLine("Cantidad de CPU creadas: "+cantidadCpuArmadas);
            return sb.ToString();
        }

        public int HacerBenchmark()
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
            bool comparacion = false;

            if(cpu1.MotherBoard == cpu2.MotherBoard && cpu1.Procesador == cpu2.Procesador && cpu1.Ram == cpu2.Ram && cpu1.PlacaAudio == cpu2.PlacaAudio && cpu1.PlacaRed == cpu2.PlacaRed)
            { 
                comparacion = true;
            }

            return comparacion;
        }

        public bool CompararCpu(Cpu cpuComparar)
        {
            bool comparacion = false;

            if (this.MotherBoard == cpuComparar.MotherBoard && this.Procesador == cpuComparar.Procesador && this.Ram == cpuComparar.Ram && this.PlacaAudio == cpuComparar.PlacaAudio && this.PlacaRed == cpuComparar.PlacaRed)
            {
                comparacion = true;
            }

            return comparacion;
        }

    }
}
