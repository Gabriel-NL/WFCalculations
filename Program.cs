namespace WFCalculations
{
    using System;
    using System.Linq;


    public class Program // Add the class name "Program"
    {
        static void Main(string[] args)
        {
            Console.Clear();

            WeaponDataModel base_weapon = WeaponList.RubicoPrime;
            string target=Constants.orokin;
            
            ModInteraction modInteraction = new ModInteraction(base_weapon);
            List<string[]> combinations_list =modInteraction.GenerateCombinations( );

            WeaponDataModel best_weapon=new WeaponDataModel();
            float highest_base_damage=0;
            string[] bestMods=[];
            foreach (var combination in combinations_list)
            {
                WeaponDataModel weaponClone = new(base_weapon);
                
                ModInteraction cloneModder = new(weaponClone);
                foreach (var mod in combination)
                {
                    
                    cloneModder.modSlots.Add( mod,ModList.MOD_DICTIONARY_PRIMARY[mod]);
                }
                cloneModder.SetTarget(target);
                cloneModder.ApplyChanges();
                cloneModder.weapon.SetTargetEffectiveness(DummyEnemyTest.ALL_ENEMIES[target]);
                float current_dmg=weaponClone.GetQuantumDmg();
                        
                if (current_dmg>highest_base_damage)
                {
                    highest_base_damage=current_dmg;
                    bestMods=combination;
                    best_weapon=weaponClone;
                    
                }
                cloneModder.modSlots.Clear();

            }
            Console.WriteLine($"Weapon name: {best_weapon.Name}");
            Console.WriteLine($"Target type: {target}");
            Console.WriteLine($"Dmg per shot: {highest_base_damage} ");
            Console.WriteLine($"Dmg on crit: {best_weapon.totalCritDMG}");
            Console.WriteLine($"Damage values:");
            best_weapon.GetAllDamages();
            Console.WriteLine($"Build used:");
            foreach (var mod in bestMods)
            {
                Console.Write(mod.ToString()+", ");
            }

        }

        public static WeaponDataModel ShowBestZaw()
        {
            WeaponDataModel BestZaw = new ZawBuildClass("Sample", "Sample", "Sample").built_weapon;

            var combinations =
                from strike in Constants.ALLZAWSTRIKES
                from grip in Constants.ALLZAWGRIPS
                from link in Constants.ALLZAWLINKS
                select new
                {
                    strike,
                    grip,
                    link
                };

            foreach (var combination in combinations)
            {
                WeaponDataModel weapon = new ZawBuildClass(
                    combination.strike,
                    combination.grip,
                    combination.link
                ).built_weapon;

                if (
                    (weapon.GetBaseDamage() > BestZaw.GetBaseDamage())
                    || (BestZaw.GetBaseDamage() == 0)
                )
                {
                    if (weapon.Type == "Dagger")
                    {
                        BestZaw = weapon;
                    }
                }
            }
            return BestZaw;
        }

        public void ShowAdvancedStats(WeaponDataModel weapon)
        {
            Console.WriteLine(Constants.SEPARATOR);
            foreach (var pair in weapon.Components)
            {
                Console.Write($"/{pair.Key}:{pair.Value}/");
            }
            Console.WriteLine($"Base dmg per hit={weapon.GetBaseDamage()}");
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
            Console.WriteLine($"Base dmg={weapon.GetBaseDamage()}");
            Console.WriteLine(Constants.SEPARATOR);
        }
    }
}
