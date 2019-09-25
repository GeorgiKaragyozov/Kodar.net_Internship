using System;
using WeaponVariantOne.Hero;
using WeaponVariantOne.Weapons;

namespace Weapon_Demo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //IWeapon revolver = new Revolver() or ;
            Revolver revolver = new Revolver();

            Player player1 = new Player(revolver, "Zed");
            player1.Action();

            Console.WriteLine();

            Player player2 = new Player(revolver, "Jix");
            player2.Action();

            Console.WriteLine();

            Sword sword = new Sword();
            Player player3 = new Player(sword, "Soraka");
            player3.Action();

            Console.ReadKey();
        }
    }
}
