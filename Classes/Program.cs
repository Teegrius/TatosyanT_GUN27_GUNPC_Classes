using System;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Examples of creating units
            Unit defaultUnit = new Unit();
            Unit hero = new Unit("Hero");

            Console.WriteLine($"Default Unit: {defaultUnit.Name}, Health: {defaultUnit.Health}, Armor: {defaultUnit.Armor}, Damage: {defaultUnit.Damage}");
            Console.WriteLine($"Hero: {hero.Name}, Health: {hero.Health}, Armor: {hero.Armor}, Damage: {hero.Damage}");

            // Testing the SetDamage method
            bool isDead = hero.SetDamage(3);
            Console.WriteLine($"{hero.Name} took 3 damage. Effective health: {hero.GetEffectiveHealth()}, Dead? {isDead}");

            isDead = hero.SetDamage(10);
            Console.WriteLine($"{hero.Name} took 10 damage. Effective health: {hero.GetEffectiveHealth()}, Dead? {isDead}");
        }
    }

    public class Unit
    {
        // Private fields
        private float _health;

        // Properties
        public string Name { get; }
        public float Health { get { return _health; } }
        public int Damage { get; }
        public float Armor { get; }

        // Constructors
        public Unit() : this("Unknown Unit") { }

        public Unit(string name)
        {
            Name = name;
            _health = 100f;  // Starting health
            Damage = 5;
            Armor = 0.6f;
        }

        // Method to get effective health considering armor
        public float GetEffectiveHealth()
        {
            return _health * (1f + Armor);
        }

        // Method to apply damage
        public bool SetDamage(float value)
        {
            _health -= value * Armor;
            return _health <= 0f;
        }
    }
}
