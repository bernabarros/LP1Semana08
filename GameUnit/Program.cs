using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Unit u1 = new MilitaryUnit(3,5,2);
            Unit u2 = new SettlerUnit(2,2);

           Console.WriteLine(u1.Health);
           Console.WriteLine(u2.Health);
           Console.WriteLine(u2.Cost);
        }
    }
}
