﻿namespace WFCalculations
{
    using WFCalculations;
    using System;
    using System.Runtime.InteropServices;
    using System.Linq;


    public class Program  // Add the class name "Program"
    {
        static void Main(string[] args)
        {
            Console.Clear();

            WeaponDataModel BestZaw = new ZawBuildClass("Sample", "Sample", "Sample").built_weapon;

            var combinations = from strike in Constants.ALLZAWSTRIKES
                               from grip in Constants.ALLZAWGRIPS
                               from link in Constants.ALLZAWLINKS
                               select new { strike, grip, link };

            foreach (var combination in combinations)
            {
                WeaponDataModel weapon = new ZawBuildClass(combination.strike, combination.grip, combination.link).built_weapon;

                if ((weapon.BaseDamage() > BestZaw.BaseDamage()) || (BestZaw.BaseDamage() == 0))
                {
                    if (weapon.Type == "Dagger")
                    {
                        BestZaw = weapon;

                    }
                }
            }

            ShowStats(BestZaw);
            StanceCalculations stanceData = new StanceCalculations(BestZaw.Type, BestZaw.BaseDamage());
            stanceData.CalculateStanceData(BestZaw.BaseDamage());



        }
        public void ShowAdvancedStats(WeaponDataModel weapon)
        {
            Console.WriteLine(Constants.SEPARATOR);
            foreach (var pair in weapon.Components)
            {
                Console.Write($"/{pair.Key}:{pair.Value}/");
            }
            Console.WriteLine($"Base dmg per hit={weapon.BaseDamage()}");
            Console.WriteLine($"Crit dmg=");
            Console.WriteLine(Constants.SEPARATOR);
        }
        public static void ShowStats(WeaponDataModel weapon)
        {
            Console.WriteLine(Constants.SEPARATOR);
            Console.WriteLine($"Weapon type={weapon.Type}");
            Console.WriteLine($"Reach ={weapon.Reach}");
            Console.WriteLine($"RD={weapon.RivenDisposition}");
            foreach (var pair in weapon.Components)
            {
                Console.Write($"/{pair.Key}:{pair.Value}/");
            }

            Console.WriteLine($"Atk Speed={weapon.AtkSpeed}");
            Console.WriteLine($"Crit chance={weapon.CritChance}%");
            Console.WriteLine($"Crit multiplier={weapon.CritMultiplier}x");
            Console.WriteLine($"Status chance={weapon.StatusChance}%");

            foreach (var pair in weapon.DamageTypes)
            {
                Console.Write($"/{pair.Key}={Math.Round(pair.Value, 1)}/");
            }
            Console.WriteLine($"Base dmg={weapon.BaseDamage()}");
            Console.WriteLine(Constants.SEPARATOR);

        }



    }
}