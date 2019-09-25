using System;
using WeaponVariantTwo.Hero;
using WeaponVariantTwo.Weapons;

namespace WeaponVariantTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Weapon knife = new Knife();

            Player player1 = new Player(knife, "someting");
            player1.Action();

            Console.ReadKey();
        }
    }
}
