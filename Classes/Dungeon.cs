using System;

namespace HomeWork
{
    public class Dungeon
    {
        private Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[]
            {
                new Room(new Unit("Warrior", 100, 10, 20), new Weapon("Sword", 5, 15)),
                new Room(new Unit("Archer", 80, 5, 25), new Weapon("Bow", 4, 12)),
                new Room(new Unit("Mage", 70, 8, 18), new Weapon("Staff", 6, 16))
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];
                Console.WriteLine($"Room {i + 1}:");
                Console.WriteLine($"  Unit: {room.Unit.Name}, HP: {room.Unit.Health}, Damage: {room.Unit.Damage}");
                Console.WriteLine($"  Weapon: {room.Weapon.Name}, Damage: {room.Weapon.Damage}");
                Console.WriteLine("—");
            }
        }
    }
}
