using System;
namespace problemB
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            string [] parts = Console.ReadLine().Split(' ');
            int x = int.Parse(parts[0]);
            long l = long.Parse(parts[1]);
            char c = char.Parse(parts[2]);
            float f = float.Parse(parts[3]);
            double d = double.Parse(parts[4]);

            Console.WriteLine(x);
            Console.WriteLine(l);
            Console.WriteLine(c);
            Console.WriteLine(f);
            Console.WriteLine(d);
        }
    }
}
