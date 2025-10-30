namespace HomeWork
{
    public class Unit
    {
        public string Name { get; }
        public int Health { get; }
        public int MinDamage { get; }
        public int MaxDamage { get; }

        public Unit(string name, int health, int minDamage, int maxDamage)
        {
            Name = name;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
