namespace HomeWork
{
    public class Weapon
    {
        public string Name { get; }
        public int MinDamage { get; }
        public int MaxDamage { get; }

        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
