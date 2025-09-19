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

            Console.WriteLine(Cpu.CompararEstatico(gamaBaja1,gamaBaja2));

            Cpu cpu1 = new Cpu();
            Console.WriteLine(cpu1.MostrarCpu());
            Cpu cpu2 = new Cpu();
            Console.WriteLine(cpu2.MostrarCpu());
        }
    }
}
