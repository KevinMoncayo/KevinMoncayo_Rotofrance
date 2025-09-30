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

        public Sensor(string nombre, string unidad, double valorActual):this()
        {
            this.nombre = nombre;
            this.unidad = unidad;
            this.valorActual = valorActual;
        }



        #endregion
    }
}
