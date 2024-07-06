namespace WFCalculations
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;
    using WFCalculations;

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
                    Console.WriteLine($"Current best dmg: {highest_base_damage} ");
                    bestMods=combination;
                    best_weapon=cloneModder.weapon;
                    
                    Console.WriteLine("");
                }
                cloneModder.modSlots.Clear();

            }
            Console.WriteLine($"Best dmg: {highest_base_damage} ");
            best_weapon.GetAllDamages();
            foreach (var mod in bestMods)
            {
                Console.Write(mod.ToString()+", ");
            }


            /*
            foreach (var combination in modInteraction.GenerateCombinations())
            {
                Console.WriteLine(string.Join(" + ", combination));
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("[Added mods:]");
            Console.WriteLine("");
            
            //
            //modInteraction.IteratingOverAllMod();
            //modInteraction.ApplyChanges();

            WeaponDataModel clone = new WeaponDataModel(weaponTest);
            ModInteraction mod = new ModInteraction(clone);
            mod.modSlots.Add(ModList.MOD_DICTIONARY["Buzz Kill"]);
            mod.modSlots.Add(ModList.MOD_DICTIONARY["Spoiled Strike"]);
            mod.modSlots.Add(ModList.MOD_DICTIONARY["Molten Impact"]);
            mod.ApplyChanges();
            mod.ShowAllChanges();
            clone.GetAllDamages();
            Console.WriteLine($"Clone Base dmg: {clone.GetBaseDamage()} Clone Quantum dmg: {clone.GetQuantumBaseDmg(enemy)}");
            */



            //ShowStats(BestZaw);
            //StanceCalculations stanceData = new StanceCalculations(BestZaw.Type, BestZaw.BaseDamage());
            //stanceData.CalculateStanceData(BestZaw.BaseDamage());
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
