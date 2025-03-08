using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public struct Sword : IWeapon
    {
        public string WeaponType => _type;
        private static readonly string _type = "Меч";

        public string Rarity { get; set; }

        public int WeaponStrenght { get; set; }
        public string SpecialWeaponFeatures { get; set; }


    }
}
