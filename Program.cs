namespace WFCalculations
{
    using WFCalculations;


    // Assuming the JSON data is in a file named "weapons.json"


    public class Program  // Add the class name "Program"
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WeaponListing weaponListing = new WeaponListing();
            weaponListing.WeaponData("Weapon_1");

        }
    }
}