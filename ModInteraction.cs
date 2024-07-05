namespace WFCalculations
{
    public class ModInteraction
    {
        public WeaponDataModel weapon;
        Dictionary<string, decimal> allChanges = new Dictionary<string, decimal>();
        Dictionary<string, ModData> modSlots;
        public FactionWeakness enemy;

        public ModInteraction(WeaponDataModel weapon, FactionWeakness enemy)
        {
            this.weapon = weapon;
            this.enemy = enemy;
        }

        public void IteratingOverAllMod()
        {
            int counter = 0;
            modSlots = new Dictionary<string, ModData>();
            foreach (var mod in ModList.MOD_DICTIONARY)
            {
                bool has_slots = modSlots.Count < 8;
                bool same_weapon_type = weapon.Type == mod.Value.Type;
                bool same_weapon_subtype =
                    weapon.SubType == mod.Value.SubType || mod.Value.SubType == "None";
                bool weapon_exclusive =
                    mod.Value.Exclusivity == weapon.Name || mod.Value.Exclusivity == "None";
                bool is_restricted = mod.Value.Restriction != "None";
                bool can_insert = true;
                if (has_slots && same_weapon_type && same_weapon_subtype && weapon_exclusive)
                {
                    if (is_restricted)
                    {
                        foreach (var installed_mod in modSlots)
                        {
                            if (installed_mod.Value.Restriction == mod.Key)
                            {
                                //Console.WriteLine(installed_mod.Value.Restriction);
                                //Console.WriteLine(mod.Key);

                                can_insert = false;
                            }
                        }
                    }
                    if (can_insert)
                    {
                        modSlots.Add(mod.Key, mod.Value);
                    }
                }
            }
            foreach (var data in modSlots)
            {
                Console.WriteLine($"{data.Key}");
            }
        }

        public Dictionary<string, decimal> SumAllBonus()
        {
            foreach (var mod in modSlots)
            {
                foreach (var bonus in mod.Value.mod_bonus)
                {
                    if (allChanges.ContainsKey(bonus.Key))
                    {
                        allChanges[bonus.Key] += bonus.Value;
                    }
                    else
                    {
                        allChanges.Add(bonus.Key, bonus.Value);
                    }
                }
            }
            return allChanges;
        }

        public void ShowAllChanges()
        {
            foreach (var bonus in allChanges)
            {
                Console.WriteLine($"Key: {bonus.Key} Value: +{bonus.Value}");
            }
        }

        public void ApplyChanges()
        {
            Console.WriteLine($"[Applying changes...]");
            SumAllBonus();
            Console.WriteLine("");
            Console.WriteLine($"[Current damage: {weapon.GetBaseDamage()}]");
            if (allChanges.ContainsKey(ModList.BaseDmg))
            {
                decimal DmgMultiplier = 1 + allChanges[ModList.BaseDmg];

                foreach (var dmg_type in weapon.DamageTypes)
                {
                    Console.WriteLine($"[{dmg_type.Key}] {dmg_type.Value} x {DmgMultiplier} = {dmg_type.Value*DmgMultiplier} ");
                    weapon.DamageTypes[dmg_type.Key] = dmg_type.Value*DmgMultiplier;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"[Current damage + Base dmg multiplier: {weapon.GetBaseDamage()}]");
            Dictionary<string, decimal> newElements = new Dictionary<string, decimal>();
            foreach (var alteration in allChanges)
            {
                if (Constants.baseElementalMods.Contains(alteration.Key) || Constants.complexElementalMods.Contains(alteration.Key))
                {
                    decimal newDamage = alteration.Value * weapon.GetBaseDamage();
                    Console.WriteLine($"[New element] {alteration.Key}:{newDamage}");
                    newElements.Add(alteration.Key, newDamage);
                }
                if (
                    ModList.physicalMods.Contains(alteration.Key)
                    && weapon.DamageTypes.ContainsKey(alteration.Key)
                )
                {
                    decimal newDamage = weapon.DamageTypes[alteration.Key] * (alteration.Value + 1);
                    Console.WriteLine(
                        $"{alteration.Key} = {weapon.DamageTypes[alteration.Key]} x {alteration.Value + 1}"
                    );
                    newElements.Add(alteration.Key, newDamage);
                }
            }
            foreach (var element in newElements)
            {
                if (weapon.DamageTypes.ContainsKey(element.Key))
                {
                    weapon.DamageTypes[element.Key] += element.Value;
                }
                else
                {
                    weapon.DamageTypes.Add(element.Key, element.Value);
                }
            }

            MixElements();
            Console.WriteLine("");
            Console.WriteLine($"[Current damage + Base dmg multiplier + Elemental mods: {weapon.GetBaseDamage()}]");
            foreach (var dmg in weapon.DamageTypes)
            {
                Console.WriteLine($"{dmg.Key} = {dmg.Value}");
            }
        }

        public void MixElements()
        {
            Dictionary<string, decimal> new_combinations = new Dictionary<string, decimal>();
            foreach (var dmg_type in weapon.DamageTypes)
            {
                if (Constants.baseElementalMods.Contains(dmg_type.Key) )
                {
                    new_combinations.Add(dmg_type.Key, dmg_type.Value);
                    weapon.DamageTypes.Remove(dmg_type.Key);
                }
            }

            while (new_combinations.Count > 0)
            {
                if (new_combinations.Count >= 2)
                {
                    var type1 = new_combinations.ElementAt(0);
                    var type2 = new_combinations.ElementAt(1);
                    // insert code here
                    
                    foreach (var combination in Constants.Combinations)
                    {
                        if (Check_elements((type1.Key, type2.Key), combination.Value))
                        {
                            weapon.DamageTypes.Add(combination.Key, type1.Value + type2.Value);
                            new_combinations.Remove(type1.Key);
                            new_combinations.Remove(type2.Key);
                        }
                    }
                }
                else if (new_combinations.Count == 1)
                {
                    weapon.DamageTypes.Add(
                        new_combinations.ElementAt(0).Key,
                        new_combinations.ElementAt(0).Value
                    );
                    new_combinations.Remove(new_combinations.ElementAt(0).Key);
                }
            }
        }

        /*
        Base_dmg
        *[1+pureDamageMods]
        *[
            1
            +baseCritChance
            *(1+critChanceMods)
            *(critMult
            *(1+critDmgMods)-1)
        ]
        *[1+factionMods]
        *[
            1+elementalMods
            +impactmods*impactProportion
            +puncturemods*punctureProportion
            +slashmods*slashProportion
        ]
        *baseMultishot*(1+multishotMods)]

        baseDmg
        *1+PureDmgMods
        *1+ElementalDmgMods
        
        +PunctureMods*punctureValue
        +slashMods*slashValue
        +impactMods*impactValue

        Base dmg, pure dmg, ... faction mods = modded dmg

        */

        private bool Check_elements((string, string) analysed, (string, string) target)
        {
            bool result =
                (analysed.Item1 == target.Item1 && analysed.Item2 == target.Item2)
                || (analysed.Item2 == target.Item1 && analysed.Item1 == target.Item2);
            return result;
        }
        public decimal GetModdedBaseDamage()
    {
        decimal totalDamage = weapon.GetBaseDamage();
        if (weapon.CritChance > 100)
        {
            weapon.CritTier = (int)(weapon.CritChance / 100m);
            weapon.CritChance %= 100m;
            totalDamage = weapon.CritAttack(totalDamage, weapon.CritTier - 1);
            return totalDamage;
        }
        else
        {
            return totalDamage;
        }
    }

        public double ModifiedBaseDamage()
        {
            decimal base_dmg = weapon.GetQuantumBaseDmg(enemy);

            return (double)base_dmg;
        }
    }
}
