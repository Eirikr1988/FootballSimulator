using System;

namespace FootballSimulator
{
    public class Game
    {
        public static (byte, byte) Play(ref Team home, ref Team away)
        {
            var homeGoals = GetGoals(ref home, ref away);
            var awayGoals = GetGoals(ref away, ref home);

            PrintResult(ref home, ref away, homeGoals, awayGoals);


            return (0, 0);
        }

        private static byte GetGoals(ref Team team, ref Team opponent)
        {
            Random random = new Random();
            var attackingDelta = team.AttackingStrength - opponent.DefenceStrength;
            var goals = 0;

            if (attackingDelta < -60)
            {
                // almost no change of scoring against this opponent
                goals = random.Next(0, 10);
                return (byte)(goals / 10);

            }

            if (attackingDelta < -30)
            {
                // little change of scoring against this opponent
                goals = random.Next(0, 15);
                return (byte)(goals / 10);
            }

            if (attackingDelta < -15)
            {
                // hard to score against this opponent
                goals = random.Next(0, 20);
                return (byte)(goals / 10);
            }

            if ((attackingDelta < 0) || (attackingDelta < 20))
            {
                goals = random.Next(0, 30);
                return (byte)(goals / 10);
            }

            if (attackingDelta < 40)
            {
                goals = random.Next(0, 20);
                return (byte)(goals / 10);
            }

            goals = random.Next(0, 10);
            return (byte)(goals / 10);
        }
        
        private static void PrintResult(ref Team home, ref Team away, int homeGoals, int awayGoals)
        {
            if (homeGoals == awayGoals)
            {
                // it's a draw
                Console.WriteLine($"{home.Name} have drawn {homeGoals}-{awayGoals} against {away.Name}");
            }
            else
            {
                if (homeGoals > awayGoals)
                {
                    // home win
                    Console.WriteLine($"{home.Name} have won {homeGoals}-{awayGoals} against {away.Name}");
                }
                else
                {
                    // away win
                    Console.WriteLine($"{home.Name} have lost {homeGoals}-{awayGoals} against {away.Name}");
                }
            }
        }
    }
}
