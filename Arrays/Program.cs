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
        static int maxAmmo;
        static int currentWeapon;

        static void Main(string[] args)
        {
            ammo = new int[5];
            currentWeapon = 0;
            maxAmmo = 100;

            for (int i = 0; i < ammo.Length; i++) 
            {
                ammo[i] = 10;
            }

            //Console.WriteLine("--------------");
            currentWeapon = 3;
            ShowHUD();
            Fire();
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

        static string CurrentWeaponString()
        {
            if (currentWeapon == 0)
            {
                return "Pistol";
            }
            else if (currentWeapon == 1)
            {
                return "Shotgun";
            }
            else if (currentWeapon == 2)
            {
                return "Spreader";
            }
            else if (currentWeapon == 3)
            {
                return "Rocket Launcher";
            }
            else if (currentWeapon == 4)
            {
                return "BFG";
            }
            return "Pistol";
        }

        static void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("WEAPON SYSTEM");
            Console.WriteLine("--------------");
            Console.WriteLine("Current Weapon: " + CurrentWeaponString());
            Console.WriteLine("Pistol: " + ammo[0] + " | " + "Shotgun: " + ammo[1] + " | " + "Spreader: " + ammo[2] + " | " + "Rocket Launcher: " + ammo[3] + " | " + "BFG: " + ammo[4]);
        }
    }
}
