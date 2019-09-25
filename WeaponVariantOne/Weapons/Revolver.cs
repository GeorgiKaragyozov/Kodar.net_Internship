using System;

namespace WeaponVariantOne.Weapons
{
    public class Revolver : IWeapon
    {
        public void Action()
        {
            Console.WriteLine("Perfom revolver attack");
        }
    }
}
