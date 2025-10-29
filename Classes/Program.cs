using System;

namespace RPt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Примеры создания юнитов
            Unit defaultUnit = new Unit();
            Unit hero = new Unit("Hero");

            Console.WriteLine($"Default Unit: {defaultUnit.Name}, Health: {defaultUnit.Health}, Armor: {defaultUnit.Armor}, Damage: {defaultUnit.Damage}");
            Console.WriteLine($"Hero: {hero.Name}, Health: {hero.Health}, Armor: {hero.Armor}, Damage: {hero.Damage}");

            // Проверка метода SetDamage
            bool isDead = hero.SetDamage(3);
            Console.WriteLine($"{hero.Name} получил 3 урона. Реальное здоровье: {hero.GetRealHealth()}, Мертв? {isDead}");

            isDead = hero.SetDamage(10);
            Console.WriteLine($"{hero.Name} получил 10 урона. Реальное здоровье: {hero.GetRealHealth()}, Мертв? {isDead}");
        }
    }

    public class Unit
    {
        // Приватные поля
        private float _health;

        // Свойства
        public string Name { get; }
        public float Health { get { return _health; } }
        public int Damage { get; }
        public float Armor { get; }

        // Конструкторы
        public Unit() : this("Unknown Unit") { }

        public Unit(string name)
        {
            Name = name;
            _health = 100f;  // Можно задать любое стартовое здоровье
            Damage = 5;
            Armor = 0.6f;
        }

        // Метод для получения реального здоровья с учетом брони
        public float GetRealHealth()
        {
            return _health * (1f + Armor);
        }

        // Метод для нанесения урона
        public bool SetDamage(float value)
        {
            _health -= value * Armor;
            return _health <= 0f;
        }
    }
}
