using System;

namespace HomeWork
{
    public class Weapon
    {
        public string Name { get; }
        public int MinDamage { get; }
        public int MaxDamage { get; }

        private Random random;

        public Weapon(string name, int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                (minDamage, maxDamage) = (maxDamage, minDamage);
                Console.WriteLine("Invalid input: min > max. Values have been swapped.");
            }

            if (minDamage < 0)
            {
                Console.WriteLine("Invalid input: min < 0. Set to 0.");
                minDamage = 0;
            }

            if (maxDamage <= 0)
            {
                Console.WriteLine("Invalid input: max <= 0. Set to 10.");
                maxDamage = 10;
            }

            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;

            random = new Random();
        }

        public int GetDamage()
        {
            return random.Next(MinDamage, MaxDamage + 1);
        }

        public override string ToString()
        {
            return $"{Name} (Damage: {MinDamage}-{MaxDamage})";
        }
    }
}
