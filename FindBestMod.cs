using System.Security.Cryptography.X509Certificates;

namespace WFCalculations
{
    public class FindBestMod
    {
        private WeaponDataModel weapon, modded_weapon;
        private EnemyData enemy;

        public FindBestMod(WeaponDataModel weapon)
        {
            modded_weapon = weapon;
        }
        public void StoreModChanges()
        {

            List<ModData> modSlots = new List<ModData>();
            int counter = 0;
            foreach (var mod in ModList.MOD_LIST)
            {
                if (modSlots.Count() < 7 && !modSlots.Contains(mod))
                {
                    modSlots.Add(mod);
                }
                else
                {
                    EvalueteIfModIsBetter(mod, modSlots);
                }

            }

            ModData modChanges = new ModData();
            foreach (ModData mod in modSlots)
            {
                foreach (KeyValuePair<string, float> entry in mod.mod_bonus)
                {
                    string Key = entry.Key;
                    float Value = entry.Value;

                    modChanges.mod_bonus[Key] = Value;
                }
            }





        }

        public ModData EvalueteIfModIsBetter(ModData new_mod, List<ModData> modSlots)
        {


            return new_mod;
        }

        public float ApplyChanges(WeaponDataModel weapon, ModData allChanges)
        {
            float totalDamage = 0;
            if (allChanges.mod_bonus.ContainsKey(ModList.BaseDmg))
            {
                foreach (var dmg_type in weapon.DamageTypes)
                {

                }
            }


            return 0;
        }

        /*
        Base_dmg * 
        [1+pureDamageMods]*
        [1+baseCritChance*(1+critChanceMods)*
        (critMult*(1+critDmgMods)-1)]*
        [1+factionMods]*

        [1+elementalMods+
        impactmods*impactProportion+
        puncturemods*punctureProportion+
        slashmods*slashProportion]
        *baseMultishot*(1+multishotMods)]

        Base dmg, pure dmg, ... faction mods = modded dmg

        */
        public double ModifiedBaseDamage()
        {
            float base_dmg = weapon.QuantumBaseDmg(enemy)
            * 1
            ;

            return base_dmg;
        }

    }

}