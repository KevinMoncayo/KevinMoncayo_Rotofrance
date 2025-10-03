using MonitorSensoresAmbientales;

namespace ConsolaMonitorSensoresAmbientales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Sensor LM35 = new Sensor("LM35", "ºC");
            Sensor SensorCalidadAire = new Sensor();
            
            
            //llamada a método datasheet
            Console.WriteLine(LM35.Datasheet());
            Console.WriteLine(SensorCalidadAire.Datasheet());

            SensorCalidadAire.Nombre = "MQ135";
            SensorCalidadAire.Unidad = "ppm";

            Console.WriteLine($"EL sensor {SensorCalidadAire.Nombre} ha sido actualizado!");

            //llamada al método LeerSensor() a través de la propiedad LeerValorTTL.

            Console.WriteLine($"El nuevo valor del sensor es {LM35.LeerValorTTL}");

            if (LM35.ValidarLecturaSensor(0, 5))
            {
                LM35.LecturasSensor = LM35.ValorActual;//LecturasSensor debería llamarse AddReadSensor...
            }

            //llamada a método datasheet
            Console.WriteLine(LM35.Datasheet());
            Console.WriteLine(SensorCalidadAire.Datasheet());
            */
            bool continuar = true;
            int opcionElegida;

            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-----------APP_SENSORES-----------v1.0");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Ingrese una opción del siguiente menú:");
                Console.WriteLine("\t0) Salir)");
                Console.WriteLine("\t1) Crear sensor.)");
                Console.WriteLine("\t2) Leer sensor.)");
                Console.WriteLine("\t3) Ver historial.)");
                opcionElegida = int.Parse(Console.ReadLine());
                while(opcionElegida != 0 && opcionElegida != 1 && opcionElegida != 2 && opcionElegida != 3)
                {
                    Console.WriteLine("Opcion incorrecta, ingrese una opción válida!");
                    opcionElegida = int.Parse(Console.ReadLine());
                }
                switch (opcionElegida) 
                {
                    case 0:
                        Console.WriteLine("Saliendo...");
                        continuar = false;
                        break;
                    case 1:
                        Console.WriteLine("Opcion 1 elegida!");
                        break;
                    case 2:
                        Console.WriteLine("Opcion 2 elegida!");
                        break;
                    case 3:
                        Console.WriteLine("Opcion 3 elegida!");
                        break;
                    default:
                        Console.WriteLine("Estado indeseado...");
                        break;
                }
            }
            while (continuar);
        }
    }
}
