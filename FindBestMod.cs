using System.Security.Cryptography.X509Certificates;

namespace WFCalculations
{
    public class FindBestMod
    {
        WeaponDataModel weapon, modded_weapon;


        public FindBestMod(WeaponDataModel weapon)
        {
            modded_weapon = weapon;
        }

        public double ModifiedBaseDamage()
        {
            float base_dmg = weapon.BaseDamage();

            return 0;
        }

    }

}