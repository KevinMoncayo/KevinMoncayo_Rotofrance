namespace ej_while_1
{
    /*
    Validación de contraseña

        Pedir al usuario que ingrese una contraseña (string) y repetir hasta que escriba "1234". Mostrar cuántos intentos le tomó. 
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "1234";
            string password_ingresado;
            int cantidad_intentos = 0;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese la contraseña:");
                password_ingresado = Console.ReadLine();

                if (password_ingresado == password)
                {
                    Console.WriteLine("Contraseña correcta");
                    Console.WriteLine($"La cantidad de intentos que le tomó: {cantidad_intentos}");
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    cantidad_intentos++;
                    Console.WriteLine($"Usted lleva: {cantidad_intentos} intentos hasta ahora...");
                }


            }
        }
    }
}
