namespace WFCalculations
{
    public class WeaponListing
    {


        // ... set other properties

        public void List()
        {
            // Use the WeaponStats class here
            WeaponDataModel weapon = new WeaponDataModel();
            weapon.Impact = 7;
            weapon.Puncture = 7;
            weapon.Slash = 266;

            double baseDamage = weapon.CalculateBaseDamage();
            Console.WriteLine($"Base Damage: {baseDamage}");

            double modifiedDamage = weapon.CalculateModifiedBaseDamage();
            Console.WriteLine($"Modified Base Damage: {modifiedDamage}");
        }





    }
}