using System;

namespace FootballSimulator
{
    public class Team
    {
        public Team(string name, byte defenceStrength, byte attackingStrength)
        {
            Name = name;
            DefenceStrength = defenceStrength;
            AttackingStrength = attackingStrength;
        }

        public string Name { get; }
        public byte DefenceStrength { set; get; }
        public byte AttackingStrength { set; get; }
    }
}
