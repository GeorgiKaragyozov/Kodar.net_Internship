using System;
using WeaponVariantOne.Weapons;

namespace WeaponVariantOne.Hero
{
    public class Player
    {
        private IWeapon _weapon;

        private string _nameHero;

        public Player(IWeapon weapon, string nameHero)
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
