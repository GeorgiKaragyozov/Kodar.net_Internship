using System;

namespace WeaponVariantOne.Weapons
{
    public class Sword : IWeapon
    {
        public void Action()
        {
            Console.WriteLine("Perform sword attack");
        }
    }
}
