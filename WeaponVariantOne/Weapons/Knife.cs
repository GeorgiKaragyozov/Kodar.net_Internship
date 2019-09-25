using System;

namespace WeaponVariantOne.Weapons
{
    public class Knife : IWeapon
    {
        public void Action()
        {
            Console.WriteLine("Perform knife attack");
        }
    }
}
