using PartesComputador;

namespace EnsambladorPc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cpu gamaBaja1 = new Cpu("A520", 8, "Ryzen 3 3200g", "Realtek", "Realtek");
            Console.WriteLine(gamaBaja1.MostrarCpu());
            Cpu gamaBaja2 = new Cpu("A520", 8, "Ryzen 3 3200g", "Realtek", "Realtek");
            Console.WriteLine(gamaBaja1.MostrarCpu());
            Console.WriteLine("Funcion comparar estatica.");
            Console.WriteLine(Cpu.CompararEstatico(gamaBaja1,gamaBaja2));
            Console.WriteLine("Función comparar de instancia.");
            Console.WriteLine(gamaBaja1.CompararCpu(gamaBaja2));
            

            Cpu cpu1 = new Cpu();
            Console.WriteLine(cpu1.MostrarCpu());
            Cpu cpu2 = new Cpu();
            Console.WriteLine(cpu2.MostrarCpu());

            Console.Write("Ingrese la motherboard de la cpu1: ");
            cpu1.MotherBoard = Console.ReadLine();
            Console.WriteLine(cpu1.MotherBoard);

            Console.WriteLine($"Benchmark gamaBaja1 {gamaBaja1.Benchmark}");

            cpu1.SistemaRefrigeracion = "Refrigeración por aire";
            Console.WriteLine($"El sistema de refrigeración de la CPU1 es {cpu1.SistemaRefrigeracion}");
        }
    }
}
