using System;

namespace FootballSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var psv = new Team("PSV Eindhoven", 65, 75);
            var liv = new Team("Liverpool F.C.", 88, 92);
            for (int i = 0; i < 10; i++)
            {
                Game.Play(ref psv, ref liv);
            }
        }
    }
}
