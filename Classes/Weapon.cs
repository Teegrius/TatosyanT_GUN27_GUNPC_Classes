using System;

namespace HomeWork
{
    public class Weapon
    {
        public string Name { get; private set; }
        public Interval Damage { get; private set; }

        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            Damage = new Interval(minDamage, maxDamage);
        }

        public float GetDamage()
        {
            return Damage.Get();
        }

        public override string ToString()
        {
            return $"{Name} (Damage: {Damage})";
        }
    }
}
