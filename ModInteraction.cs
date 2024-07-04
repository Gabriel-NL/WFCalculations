using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace WFCalculations
{
    public class ModInteraction
    {
        public WeaponDataModel weapon;
        Dictionary<string, float> allChanges = new Dictionary<string, float>();
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
            modSlots= new Dictionary<string, ModData>();
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
                        modSlots.Add(mod.Key,mod.Value);
                    }
                }
            }
            foreach (var data in modSlots)
            {
                Console.WriteLine($"{data.Key}");
            }
        }

        public Dictionary<string, float> SumAllBonus()
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

        public float ApplyChanges()
        {
            SumAllBonus();

            if (allChanges.ContainsKey(ModList.BaseDmg))
            {
                float DmgMultiplier = 1 + allChanges[ModList.BaseDmg];

                foreach (var dmg_type in weapon.DamageTypes)
                {
                    weapon.DamageTypes[dmg_type.Key] *= DmgMultiplier;
                }
            }

            Dictionary<string, float> newElements = new Dictionary<string, float>();
            foreach (var alteration in allChanges)
            {
                if (ModList.elementalMods.Contains(alteration.Key))
                {
                    float newDamage = alteration.Value * weapon.GetBaseDamage();
                    newElements.Add(alteration.Key, newDamage);
                }
                if (
                    ModList.physicalMods.Contains(alteration.Key)
                    && weapon.DamageTypes.ContainsKey(alteration.Key)
                )
                {
                    float newDamage = weapon.DamageTypes[alteration.Key] * (alteration.Value + 1);
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

            return 0;
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
        public double ModifiedBaseDamage()
        {
            float base_dmg = weapon.GetQuantumBaseDmg(DummyEnemyTest.grineer) * 1;

            return base_dmg;
        }
    }
}
