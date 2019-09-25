using System;
using WeaponVariantTwo.Weapons;

namespace WeaponVariantTwo.Hero
{
    public class Player
    {
        private Weapon _weapon;

        private string _nameHero;

        public Player(Weapon weapon, string nameHero)
        {
            this._weapon = weapon;
            this._nameHero = nameHero;
        }

        public void Action()
        {
            Console.Write("The name of the hero is "
                + this._nameHero + " and he ");
            _weapon.Action();
        }
    }
}
