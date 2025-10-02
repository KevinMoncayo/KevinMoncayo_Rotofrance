using MonitorSensoresAmbientales;

namespace ConsolaMonitorSensoresAmbientales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sensor LM35 = new Sensor("LM35", "ºC");
            Sensor SensorCalidadAire = new Sensor();
            
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-----------APP_SENSORES-----------v1.0");
            Console.WriteLine("--------------------------------------");
            //llamada a método datasheet
            Console.WriteLine(LM35.Datasheet());
            Console.WriteLine(SensorCalidadAire.Datasheet());

            SensorCalidadAire.Nombre = "MQ135";
            SensorCalidadAire.Unidad = "ppm";

            Console.WriteLine($"EL sensor {SensorCalidadAire.Nombre} ha sido actualizado!");

            //llamada al método LeerSensor() a través de la propiedad LeerValorTTL.
            LM35.LecturasSensor = LM35.LeerValorTTL;//LecturasSensor debería llamarse AddReadSensor...

            LM35.ValidarLecturaSensor(0, 5);

        }
    }
}
