using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        static int[] ammo;
        static string[] weapons;
        static int maxAmmo;
        static int currentWeapon;

        static void Main(string[] args)
        {
            ammo = new int[5];
            weapons = new string[5];
            currentWeapon = 0;
            maxAmmo = 10;

            for (int i = 0; i < ammo.Length; i++)
            {
                ammo[i] = 10;
            }

            weapons[0] = "Pistol";
            weapons[1] = "Shotgun";
            weapons[2] = "Spreader";
            weapons[3] = "Rocket Launcher";
            weapons[4] = "BFG";

            //Console.WriteLine("--------------");
            currentWeapon = 3;
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Reload();
            ShowHUD();
            Console.ReadLine();
        }

        static void Fire()
        {
            if (currentWeapon > ammo.Length)
            {
                return;
            }
            if (ammo[currentWeapon] <= 0)
            {
                Console.WriteLine("Error: Gun Does not Have Ammo");
                return;
            }
            ammo[currentWeapon]--;
        }

        static void Reload()
        {
            ammo[currentWeapon] = maxAmmo;
        }

        static void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("WEAPON SYSTEM");
            Console.WriteLine("--------------");
            Console.WriteLine("Current Weapon: " + weapons[currentWeapon]);
            Console.WriteLine(weapons[0] + ": " + ammo[0] + " | " + weapons[1] + ": " + ammo[1] + " | " + weapons[2] + ": " + ammo[2] + " | " + weapons[3] + ": " + ammo[3] + " | " + weapons[4] + ": " + ammo[4]);
        }
    }
}
