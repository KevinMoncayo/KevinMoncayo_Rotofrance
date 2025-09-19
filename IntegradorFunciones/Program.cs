namespace IntegradorFunciones
{
    internal class Program
    {
        public static string PedirCadena(string mensaje)
        {
            string cadenaIngresada;

            do
            {
                Console.Write(mensaje);
                cadenaIngresada = Console.ReadLine();
            }
            while (cadenaIngresada == string.Empty);

            return cadenaIngresada;
        }

        public static bool ValidarCadenaTresOpciones(ref string cadena, string opcion1, string opcion2, string opcion3)
        {
            bool cadenaValidada = false;
            string mensaje = $"No se ha elegido una opción permitida, las opciones disponibles son: {opcion1}, {opcion2} y {opcion3}.\nReingrese una opcion permitida: ";

            do
            {
                cadena = PedirCadena(mensaje);
            }
            while (cadena != opcion1 && cadena != opcion2 && cadena != opcion3);

            cadenaValidada = true;
            return cadenaValidada;
        }

        public static int pedirEntero(string mensaje)
        {
            int numeroIngresado;

            Console.WriteLine(mensaje);
            numeroIngresado = int.Parse(Console.ReadLine());

            return numeroIngresado;
        }

        public static bool ValidarEnteroRango(ref int numero2validar, int limiteInferior, int limiteSuperior)
        {
            bool enteroValidado = false;
            string mensaje = $"Número ingresado por fuera del rango permitido. Ingrese un numero entre {limiteInferior} y {limiteSuperior}.";

            do
            {
                Console.WriteLine(mensaje);
                numero2validar = int.Parse(Console.ReadLine());
            }
            while (numero2validar < limiteInferior || numero2validar > limiteSuperior);

            enteroValidado = true;

            return enteroValidado;
        }

        static void Main(string[] args)
        {
            //Inicialización de variables
            string nombreEmpleado;
            string mensajeSolicitudNombreEmpleado = "Por favor ingrese el nombre del empleado: ";
            string formaNave1 = "Platillo";
            string formaNave2 = "Esférica";
            string formaNave3 = "Ovalada";
            string mensajeSolicitudFormaNave = "Ahora ingrese la forma de la nave: ";
            string formaNave;
            string mensajeVelocidadMaxima = "Ingrese la valocidad máxima de la nave (km/h): ";
            int limiteInferiorVelocidadNave = 100;//Velocidad en km/h
            int limiteSuperiorVelocidadNave = 1000;//Velocidad en km/h
            int velocidadNave;
            string mensajeTipoMensaje = "Por favor ingrese el tipo de mensaje detectado: ";
            string tipoMensaje1 = "Ninguno";
            string tipoMensaje2 = "Claro";
            string tipoMensaje3 = "Incomprensible";
            string tipoMensajeIngresado;
            bool continuarIngresandoDatos = true;
            string mensajeContinuarIngresandoDatos = "¿Desea agregar otro registro? (Digite Si para continuar): ";
            string respuestaIngresarDatos;

            //Necesito saber la velocidad promedio segun la forma de la nave.
            int contadorFormaNave1 = 0;
            int contadorFormaNave2 = 0;
            int contadorFormaNave3 = 0;
            int contadorIngresos = 0;
            double promedioFormaNave1 = 0;
            double promedioFormaNave2 = 0;
            double promedioFormaNave3 = 0;
            int velocidadAcumuladaFormaNave1 = 0;
            int velocidadAcumuladaFormaNave2 = 0;
            int velocidadAcumuladaFormaNave3 = 0;

            // Porcentaje de avistamientos con algún tipo de mensaje, Siempre y cuando la velocidad se encuentre entre los 200 km/h y los 500 km/h.
            int avistamientosConsignaB = 0;
            double promedioConsignaB = 0;

            // Tipo de mensaje menos recibido.
            int contadorTipoMensaje1 = 0;
            int contadorTipoMensaje2 = 0;
            int contadorTipoMensaje3 = 0;

            // Si por lo menos algún empleado se llama “Mercedes” 
            bool banderaMercedes = false;

            // Nombre del empleado y forma de la nave del avistamiento con mensaje Incomprensible, de la nave que resultó ser más rápida.
            string nombreEmpleadoNaveMasRapida = "";
            string formaNaveMasRapida = "";
            int velocidadNaveMasRapida = 0;

            // Nombre del empleado y forma de la nave del avistamiento con mensaje Incomprensible, de la nave que resultó ser más rápida. 
            bool banderaConsignaD = false;

            //Ejecución del programa

            while (continuarIngresandoDatos)
            {

                nombreEmpleado = PedirCadena(mensajeSolicitudNombreEmpleado);

                do
                {
                    formaNave = PedirCadena(mensajeSolicitudFormaNave);
                }
                while (!(ValidarCadenaTresOpciones(ref formaNave, formaNave1, formaNave2, formaNave3)));


                do
                {
                    velocidadNave = pedirEntero(mensajeVelocidadMaxima);
                }
                while (!(ValidarEnteroRango(ref velocidadNave, limiteInferiorVelocidadNave, limiteSuperiorVelocidadNave)));


                do
                {
                    tipoMensajeIngresado = PedirCadena(mensajeTipoMensaje);
                }
                while (!(ValidarCadenaTresOpciones(ref tipoMensajeIngresado, tipoMensaje1, tipoMensaje2, tipoMensaje3)));

                //Contadores
                if (formaNave == formaNave1)
                {
                    contadorFormaNave1++;
                    velocidadAcumuladaFormaNave1 += velocidadNave;
                }
                if (formaNave == formaNave2)
                {
                    contadorFormaNave2++;
                    velocidadAcumuladaFormaNave2 += velocidadNave;
                }
                if (formaNave == formaNave3)
                {
                    contadorFormaNave3++;
                    velocidadAcumuladaFormaNave3 += velocidadNave;
                }

                if ((tipoMensajeIngresado == tipoMensaje2 || tipoMensajeIngresado == tipoMensaje3) && (velocidadNave > 200 && velocidadNave < 500))
                {
                    //Avistamientos que cumplen la consigna B.
                    avistamientosConsignaB++;
                }

                //Hago un contador de los tipos de mensaje
                if (tipoMensajeIngresado == tipoMensaje1)
                {
                    contadorTipoMensaje1++;
                }
                else if (tipoMensajeIngresado == tipoMensaje2)
                { 
                    contadorTipoMensaje2++;
                }else
                {
                    contadorTipoMensaje3++;
                }

                if (nombreEmpleado == "Mercedes")
                {
                    banderaMercedes = true;
                }

                // Nombre del empleado y forma de la nave del avistamiento con mensaje Incomprensible, de la nave que resultó ser más rápida.
                if (velocidadNave > velocidadNaveMasRapida && tipoMensajeIngresado == tipoMensaje3)
                {
                    nombreEmpleadoNaveMasRapida = nombreEmpleado;
                    formaNaveMasRapida = formaNave;
                    velocidadNaveMasRapida = velocidadNave;
                    banderaConsignaD = true;
                }

                contadorIngresos++;

                respuestaIngresarDatos = PedirCadena(mensajeContinuarIngresandoDatos);
                if (respuestaIngresarDatos != "Si")
                {
                    //Muestro resultados
                    //A. Velocidad promedio según la forma de la nave.
                    if (contadorFormaNave1 == 0)
                    {
                        Console.WriteLine($"No se ingresaron avistamientos con forma de nave {formaNave1}");
                        promedioFormaNave1 = 0;
                    }
                    else
                    {
                        promedioFormaNave1 = ((double)velocidadAcumuladaFormaNave1 / contadorFormaNave1);
                    }

                    if (contadorFormaNave2 == 0)
                    {
                        Console.WriteLine($"No se ingresaron avistamientos con forma de nave {formaNave2}");
                        promedioFormaNave2 = 0;
                    }
                    else
                    {
                        promedioFormaNave2 = ((double)velocidadAcumuladaFormaNave2 / contadorFormaNave2);
                    }

                    if (contadorFormaNave3 == 0)
                    {
                        Console.WriteLine($"No se ingresaron avistamientos con forma de nave {formaNave3}");
                        promedioFormaNave3 = 0;
                    }
                    else
                    {
                        promedioFormaNave3 = ((double)velocidadAcumuladaFormaNave3 / contadorFormaNave3);
                    }

                    //B. Porcentaje de avistamientos con algún tipo de mensaje, Siempre y cuando la velocidad se encuentre entre los 200 km/h y los 500 km/h.
                    if (avistamientosConsignaB == 0)
                    {
                        Console.WriteLine("No se ingresaron avistamientos con algún tipo de mensaje, Siempre y cuando la velocidad se encuentre entre los 200 km/h y los 500 km/h.");
                        promedioConsignaB = 0;
                    }
                    else
                    {
                        promedioConsignaB = ((double)avistamientosConsignaB / contadorIngresos)*100;
                    }

                    //C. Tipo de mensaje menos recibido. 
                    if (contadorTipoMensaje1 < contadorTipoMensaje2 && contadorTipoMensaje1 < contadorTipoMensaje3)
                    {
                        Console.WriteLine($"El tipo de mensaje menos recibido es {tipoMensaje1}");
                    }else if (contadorTipoMensaje2 < contadorTipoMensaje3)
                    {
                        Console.WriteLine($"El tipo de mensaje menos recibido es {tipoMensaje2}");
                    }else
                    {
                        Console.WriteLine($"El tipo de mensaje menos recibido es {tipoMensaje3}");
                    }

                    //D. Nombre del empleado y forma de la nave del avistamiento con mensaje Incomprensible, de la nave que resultó ser más rápida.
                    if (banderaConsignaD == true)
                    {
                        Console.WriteLine($"El empleado {nombreEmpleadoNaveMasRapida} con forma de nave {formaNaveMasRapida}, fue la nave más rápida con tipo de mensaje {tipoMensaje3}.");
                    }
                    

                    //E. Cantidad de avistamientos que superen los 250 Km/h, cuyo mensaje sea Claro o incomprensible y que sea de tipo Esférica. 


                    //F. Si por lo menos algún empleado se llama "Mercedes".
                    if (banderaMercedes == true)
                    {
                        Console.WriteLine("Por lo menos hay un empleado que se llama Mercedes.");
                    }
                    else
                    {
                        Console.WriteLine("No hay ningún empleado que se llame Mercedes.");
                    }


                    Console.WriteLine($"La velocidad promedio según la forma de la nave es:\n{formaNave1} = {promedioFormaNave1} km/h.\n{formaNave2} = {promedioFormaNave2} km/h.\n{formaNave3} = {promedioFormaNave3} km/h.");


                    Console.WriteLine("Gracias por usar el programa. Hasta la próxima!!!");
                    continuarIngresandoDatos = false;
                }

            }

        }
    }
}
