using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public class Character<T> where T : IWeapon
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public T Weapon { get; set; }
        public int Strength { get; set; }

        public string Info() => $"Имя: {Name}, Раса: {Race}, Оружие: {Weapon}, Сила персонажа: {Strength}, сила персонажа вместе с оружием: {Strength + Weapon.WeaponStrenght}";
    }
}
