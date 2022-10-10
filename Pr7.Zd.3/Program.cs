//Известен объем и масса тела. Определить плотность материала этого тела.
using System;
using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, m, p;
            Console.WriteLine("Введите значение массы (m): ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение объема(V): ");
            V = Convert.ToDouble(Console.ReadLine());
            p = m / V;
            Console.WriteLine("Плотность материала этого тела равна: {0}", Math.Round(p,4));
            Console.ReadLine();

        }
    }
}