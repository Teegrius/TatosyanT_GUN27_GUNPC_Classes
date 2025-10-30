using RPG;

namespace HomeWork
{
    public struct Room
    {
        public Unit Unit { get; }
        public Weapon Weapon { get; }

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }

        public override string ToString()
        {
            return $"Unit: {Unit.Name}, Weapon: {Weapon.Name}";
        }
    }
}
