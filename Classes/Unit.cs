using System;

namespace HomeWork
{
    public class Unit
    {
        public string Name { get; private set; }
        public float Health { get; private set; }
        public Interval Damage { get; private set; }

        public Unit(string name, float health, int minDamage, int maxDamage)
        {
            Name = name;
            Health = health;
            Damage = new Interval(minDamage, maxDamage);
        }

        public float GetDamage()
        {
            return Damage.Get();
        }

        public override string ToString()
        {
            return $"{Name} (HP: {Health}, Damage: {Damage})";
        }
    }
}
