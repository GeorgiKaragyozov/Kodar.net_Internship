using System;

namespace WeaponVariantOne.Weapons
{
    public class PlasmaGun : IWeapon
    {
        public void Action()
        {
            Console.WriteLine("Perform plasma gun attck");
        }
    }
}
