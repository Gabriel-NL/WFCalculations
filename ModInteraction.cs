using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace WFCalculations
{
    public class ModInteraction
    {
        public WeaponDataModel weapon;
        private EnemyData enemy;
        Dictionary<string, float> allChanges = new Dictionary<string, float>();
        public List<ModData> modSlots = new List<ModData>();

        public ModInteraction(WeaponDataModel weapon)
        {
            this.weapon = weapon;
        }

        public void IteratingOverAllMod()
        {
            int counter = 0;

            foreach (var mod in ModList.MOD_DICTIONARY)
            {
                if (modSlots.Count() < 8)
                {

                }
                else
                {

                }
            }

        }


        public Dictionary<string, float> SumAllBonus()
        {

            foreach (var mod in modSlots)
            {
                foreach (var bonus in mod.mod_bonus)
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
            float base_dmg = weapon.GetQuantumBaseDmg(enemy)
            * 1
            ;

            return base_dmg;
        }

    }

}