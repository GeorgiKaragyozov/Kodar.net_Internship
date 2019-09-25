using System;

namespace WeaponVariantTwo.Weapons
{
    public abstract class Weapon
    {
        public virtual void Action()
        {
            Console.WriteLine("Perfom....");
        }
    }
}
