namespace WFCalculations
{
    using System.Text.Json;
    public class WeaponListing
    {

        public Dictionary<string, Dictionary<string, object>>? weaponData;
        // ... set other properties

        public void WeaponData(string key)
        {


            // ... (Rest of your code)

            // Load the JSON data from a file (replace "weapons.json" with your actual filename)
            string jsonString = File.ReadAllText("weaponList.json");

            // Deserialize the JSON into a dictionary
            weaponData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(jsonString);

            // Access specific weapon data using the key ("Weapon_1" in this case)
            if (weaponData != null && weaponData.ContainsKey(key))
            {
                Dictionary<string, object> weaponDetails;

                weaponDetails = weaponData[key];

                string name = weaponDetails["Name"] as string;  // Cast to string if necessary

                int impact = Convert.ToInt32(weaponDetails["Impact"] as string);  // Convert to int

                Console.WriteLine($"Weapon Name: {name}");
                Console.WriteLine($"Impact Damage: {impact}");

                // Access other properties similarly, handling data types as needed
            }
            else
            {
                Console.WriteLine($"Weapon data not found for key '{key}'");
            }



        }
        public void WeaponValueCollector(object value)
        {



        }




    }
}